# Напиши программу, удаляющую из текста все слова, содержащие "абв"

string = 'ПривабВет, каабв твои дела? Чем сегодня занят?'

with open('g:/i_am_programmer/my_programs/ClassWork/2._Getting_to_know_Python/Seminars/Lesson_5._Accelerated_data_processing_lambda, filter, map, zip, enumerate, list comprehension/3.txt', 'w', encoding = 'utf-8') as file:
    file.write(string)

with open('g:/i_am_programmer/my_programs/ClassWork/2._Getting_to_know_Python/Seminars/Lesson_5._Accelerated_data_processing_lambda, filter, map, zip, enumerate, list comprehension/3.txt', 'r', encoding = 'utf-8') as file:
    stroka = file.read()

print(' '.join(list(filter(lambda x: 'абв' not in x.lower(), stroka.split()))))