num = 2**int(input("Введите степень двойки "))
number = 2

for i in range(4, num, 2):
    if num % 2**i == 0: number = i
print(number)

from math import log2


n = int(input())
i = round(log2(n)) + 1
if n % 2 != 0:
    print(1)
else:
    flag = True
while flag:
    if n % 2 ** i == 0:
        print(2 ** i)
flag = False
i -= 1
if flag:
    print(1)