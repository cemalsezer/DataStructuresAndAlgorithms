class Node:
    def __init__(self, data):
        self.data = data
        self.prev = None
        self.next = None


class DoublyLinkedList:
    def __init__(self):
        self.head = None
        self.size = 0

    def print_list(self):
        current = self.head
        while current:
            print(current.data, end=' <-> ')
            current = current.next
        print("None")

    def add(self, data):
        new_node = Node(data)
        if not self.head:
            self.head = new_node
        else:
            current = self.head
            while current.next:
                current = current.next
            current.next = new_node
            new_node.prev = current
        self.size += 1

    def get(self, index):
        if index < 0 or index >= self.size:
            raise IndexError("Index out of range")
        current = self.head
        for _ in range(index):
            current = current.next
        return current.data

    def index_of(self, value):
        current = self.head
        index = 0
        while current:
            if current.data == value:
                return index
            current = current.next
            index += 1
        return -1

    def insert_at(self, index, data):
        if index < 0 or index > self.size:
            raise IndexError("Index out of range")

        new_node = Node(data)

        if index == 0:
            new_node.next = self.head
            if self.head:
                self.head.prev = new_node
            self.head = new_node
        else:
            current = self.head
            for _ in range(index - 1):
                current = current.next
            new_node.next = current.next
            new_node.prev = current
            if current.next:
                current.next.prev = new_node
            current.next = new_node

        self.size += 1

    def remove_at(self, index):
        if index < 0 or index >= self.size:
            raise IndexError("Index out of range")

        current = self.head
        for _ in range(index):
            current = current.next

        if current.prev:
            current.prev.next = current.next
        else:
            self.head = current.next

        if current.next:
            current.next.prev = current.prev

        self.size -= 1

    def remove(self, value):
        current = self.head
        while current:
            if current.data == value:
                if current.prev:
                    current.prev.next = current.next
                else:
                    self.head = current.next
                if current.next:
                    current.next.prev = current.prev
                self.size -= 1
                return True
            current = current.next
        return False
    
    

dl1 = DoublyLinkedList()
dl1.add(10)
dl1.add(20)
dl1.add(30)
dl1.print_list()  # Output: 10 <-> 20 <-> 30 <-> None
dl1.insert_at(1, 15)
dl1.print_list()  # Output: 10 <-> 15 <-> 20 <-> 30 <-> None
dl1.remove_at(2)
dl1.print_list()  # Output: 10 <-> 15 <-> 30 <-> None
print(dl1.get(1))  # Output: 15
##head ve taili göster
print(f" head {dl1.head.data}")# Output: 10
print(f" size {dl1.size}")  # Output: 3
print(f"tail {dl1.head.next.next.data}")# Output: 30