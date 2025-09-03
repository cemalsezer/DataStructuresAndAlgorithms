class Node:
    def __init__(self, data):
        self.data = data
        self.prev = None
        self.next = None

class CircularDoublyLinkedList:
    def __init__(self):
        self.head = None
        self.size = 0

    def print_list(self):
        if not self.head:
            print("Empty list")
            return
        current = self.head
        while True:
            print(current.data, end=' <-> ')
            current = current.next
            if current == self.head:
                break
        print("(back to head)")

    def add(self, data):
        new_node = Node(data)
        if not self.head:
            self.head = new_node
            new_node.next = new_node.prev = new_node
        else:
            tail = self.head.prev
            tail.next = new_node
            new_node.prev = tail
            new_node.next = self.head
            self.head.prev = new_node
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
        while index < self.size:
            if current.data == value:
                return index
            current = current.next
            index += 1
        return -1

    def insert_at(self, index, data):
        if index < 0 or index > self.size:
            raise IndexError("Index out of range")
        new_node = Node(data)
        if self.size == 0:
            self.head = new_node
            new_node.next = new_node.prev = new_node
        elif index == 0:
            tail = self.head.prev
            new_node.next = self.head
            new_node.prev = tail
            self.head.prev = new_node
            tail.next = new_node
            self.head = new_node
        else:
            current = self.head
            for _ in range(index - 1):
                current = current.next
            new_node.next = current.next
            new_node.prev = current
            current.next.prev = new_node
            current.next = new_node
        self.size += 1

    def remove_at(self, index):
        if index < 0 or index >= self.size:
            raise IndexError("Index out of range")
        if self.size == 1:
            self.head = None
        elif index == 0:
            tail = self.head.prev
            self.head = self.head.next
            self.head.prev = tail
            tail.next = self.head
        else:
            current = self.head
            for _ in range(index):
                current = current.next
            current.prev.next = current.next
            current.next.prev = current.prev
        self.size -= 1

    def remove(self, value):
        current = self.head
        index = 0
        while index < self.size:
            if current.data == value:
                self.remove_at(index)
                return True
            current = current.next
            index += 1
        return False



cdll = CircularDoublyLinkedList()
cdll.add(10)
cdll.add(20)
cdll.add(30)
cdll.insert_at(1, 15)
cdll.print_list()     # 10 <-> 15 <-> 20 <-> 30 <-> (back to head)
print(cdll.get(2))    # 20
print(cdll.index_of(30))  # 3
cdll.remove_at(1)
cdll.remove(30)
cdll.print_list()     # 10 <-> 20 <-> (back to head)
