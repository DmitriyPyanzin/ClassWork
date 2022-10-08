# 36. Дан список чисел. Создайте список, в который попадают числа,
# описываемые возрастающую последовательность.
# Порядок элементов менять нельзя.
# *Пример:*
# [1, 5, 2, 3, 4, 6, 1, 7] => [1, 2, 3] или [1, 7] или [1, 6, 7] и т.д.

with open('g:/i_am_programmer/my_programs/ClassWork/2._Getting_to_know_Python/Seminars/Lesson_5._Accelerated_data_processing_lambda, filter, map, zip, enumerate, list comprehension/2.txt', 'w', encoding = 'utf-8') as file:
    file.write(input())

with open ('g:/i_am_programmer/my_programs/ClassWork/2._Getting_to_know_Python/Seminars/Lesson_5._Accelerated_data_processing_lambda, filter, map, zip, enumerate, list comprehension/2.txt', 'r', encoding = 'utf-8') as file:
    arr = [int(i) for i in file.read().split()]


for i in range(len(arr)):
    new_arr = list()
    temp = arr[i]
    new_arr.append(str(arr[i]))
    for j in range(i, len(arr)):
        if arr[j] > temp:
            new_arr.append(str(arr[j]))
            temp = arr[j]
    if len(new_arr) > 1:
        with open ('g:/i_am_programmer/my_programs/ClassWork/2._Getting_to_know_Python/Seminars/Lesson_5._Accelerated_data_processing_lambda, filter, map, zip, enumerate, list comprehension/2.txt', 'a', encoding = 'utf-8') as file:
            file.write('\n' + ', '.join(new_arr))

with open ('g:/i_am_programmer/my_programs/ClassWork/2._Getting_to_know_Python/Seminars/Lesson_5._Accelerated_data_processing_lambda, filter, map, zip, enumerate, list comprehension/2.txt', 'r', encoding = 'utf-8') as file:
    print(file.read())