"""
2. Найдите корни квадратного уравнения Ax² + Bx + C = 0 двумя способами:

    1) с помощью математических формул нахождения корней квадратного уравнения

    2) с помощью дополнительных библиотек Python
"""
import math

def find_x(a, b, c):
    D = b**2 - 4 * a * c
    if D > 0: return print(f"У уравнения два корня {round((-b + math.sqrt(D))/(2 * a), 2)} и {round((-b - D**0.5)/(2 * a), 2)}")
    elif D == 0: return print(f"У уравнения один корень {round(-b / (2 * a), 2)}")
    else: return print("Корней нет")

num1, num2, num3 = (int(input()) for i in range(3))

find_x(num1, num2, num3)