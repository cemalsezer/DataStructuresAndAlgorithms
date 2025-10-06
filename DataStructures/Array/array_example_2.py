# Bir dizideki en büyük ve en küçük elemanı bul.

arr = [3, 7, 2, 9, 4, 1, 8]

maxNum = arr[0]
minNum = arr[0]

for x in arr:
    if x>maxNum:
        maxNum = x
    elif x<minNum:
        minNum = x

print(f'En Büyük: {maxNum}')
print(f'En Küçük: {minNum}')


