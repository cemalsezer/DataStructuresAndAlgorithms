class CustomArray:
    def __init__(self, capacity):
        self.capacity = capacity
        self.data = [None] * capacity
        self.size = 0

    def print_array(self):
        print([self.data[i] for i in range(self.size)])

    # Access
    def get(self, index):
        if index < 0 or index >= self.size:
            raise IndexError("Index out of range")
        return self.data[index]

    # Search
    def index_of(self, value):
        for i in range(self.size):
            if self.data[i] == value:
                return i
        return -1

    # Add to end
    def add(self, value):
        if self.size == self.capacity:
            raise OverflowError("Array is full")
        self.data[self.size] = value
        self.size += 1

    # Insert at index
    def insert_at(self, index, value):
        if self.size == self.capacity:
            raise OverflowError("Array is full")
        if index < 0 or index > self.size:
            raise IndexError("Index out of range")
        for i in range(self.size, index, -1):
            self.data[i] = self.data[i - 1]
        self.data[index] = value
        self.size += 1

    # Remove at index
    def remove_at(self, index):
        if index < 0 or index >= self.size:
            raise IndexError("Index out of range")
        for i in range(index, self.size - 1):
            self.data[i] = self.data[i + 1]
        self.data[self.size - 1] = None
        self.size -= 1

    # Remove by value
    def remove(self, value):
        index = self.index_of(value)
        if index == -1:
            return False
        self.remove_at(index)
        return True


arr = CustomArray(10)

arr.add(5)
arr.add(10)
arr.add(15)
arr.print_array()  # [5, 10, 15]

arr.insert_at(1, 7)
arr.print_array()  # [5, 7, 10, 15]

print(arr.get(2))  # 10
print(arr.index_of(15))  # 3

arr.remove_at(1)
arr.print_array()  # [5, 10, 15]

arr.remove(10)
arr.print_array()  # [5, 15]
