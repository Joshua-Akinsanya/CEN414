fib_array = [0, 1]
a = 0
b = 1
BRUUH = 10000
while ((a+b)<BRUUH):
    a, b = b, a+b
    fib_array.append(b)

print(fib_array)