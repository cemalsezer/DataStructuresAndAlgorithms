nums = [1,3,5,8,6,2,5]

def contains():
    hash_nums = set()
    for num in nums:
        if num in hash_nums:
            return True
        hash_nums.add(num)
    return False
        
print(contains())