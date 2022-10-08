"""
3. Задайте два числа. Напишите программу, которая
найдёт НОК (наименьшее общее кратное) этих двух чисел.
"""
a, b = (int(input()) for i in range(2))
counter = a * b
while a != b:
    if a > b: a -= b
    else: b -= a
print(f"НОД {a}, НОК {int(counter/b)}")