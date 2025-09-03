class Node:
    def __init__(self, data):
        self.data = data
        self.next = None


class SinglyLinkedList:
    def __init__(self):
        self.head = None
        self.size = 0

    def add(self, data):
        new_node = Node(data)
        if self.head is None:
            self.head = new_node
        else:
            current = self.head
            while current.next:
                current = current.next
            current.next = new_node
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
            self.head = new_node
        else:
            current = self.head
            for _ in range(index - 1):
                current = current.next
            new_node.next = current.next
            current.next = new_node
        self.size += 1
        
    def remove_at(self, index):
        if index < 0 or index >= self.size:
            raise IndexError("Index out of range")
        if index == 0:
            self.head = self.head.next
        else:
            current = self.head
            for _ in range(index - 1):
                current = current.next
            current.next = current.next.next
        self.size -= 1
    
    def remove(self, value):
        current = self.head
        prev = None
        while current:
            if current.data == value:
                if prev is None:
                    self.head = current.next
                else:
                    prev.next = current.next
                self.size -= 1
                return True
            prev = current
            current = current.next
        return False
    
    
    def print_list(self):
        current = self.head
        while current:
            print(current.data, end=' -> ')
            current = current.next
        print("None")
        
        
ll = SinglyLinkedList()
ll.add(10)
ll.add(20)
ll.add(30)
ll.print_list()  # 10 -> 20 -> 30 -> None

ll.insert_at(1, 15)
ll.print_list()  # 10 -> 15 -> 20 -> 30 -> None

print(ll.get(2))  # 20
print(ll.index_of(30))  # 3

ll.remove_at(1)
ll.print_list()  # 10 -> 20 -> 30 -> None

ll.remove(20)
ll.print_list()  # 10 -> 30 -> None