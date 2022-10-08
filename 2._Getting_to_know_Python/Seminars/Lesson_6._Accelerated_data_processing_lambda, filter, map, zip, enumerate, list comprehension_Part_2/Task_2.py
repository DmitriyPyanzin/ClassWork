# 43. Дана последовательность чисел. Получить список уникальных элементов заданной последовательности.

# *Пример:*

# [1, 2, 3, 5, 1, 5, 3, 10] => [2, 10]

arr = input().split()
new_arr = list()
print(arr)

for i in range(len(arr)):
    if arr.count(arr[i]) == 1: new_arr.append(arr[i])

print(new_arr)