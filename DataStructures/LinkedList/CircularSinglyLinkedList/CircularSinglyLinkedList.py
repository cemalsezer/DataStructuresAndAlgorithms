class Node:
    def __init__(self, data):
        self.data = data
        self.next = None

class CircularSinglyLinkedList:
    def __init__(self):
        self.head = None
        self.size = 0

    def print_list(self):
        if not self.head:
            print("Empty list")
            return
        current = self.head
        while True:
            print(current.data, end=" -> ")
            current = current.next
            if current == self.head:
                break
        print("(back to head)")

    def add(self, data):
        new_node = Node(data)
        if not self.head:
            self.head = new_node
            new_node.next = self.head
        else:
            current = self.head
            while current.next != self.head:
                current = current.next
            current.next = new_node
            new_node.next = self.head
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
        while True:
            if current.data == value:
                return index
            current = current.next
            index += 1
            if current == self.head:
                break
        return -1

    def insert_at(self, index, data):
        if index < 0 or index > self.size:
            raise IndexError("Index out of range")
        new_node = Node(data)
        if index == 0:
            if not self.head:
                self.head = new_node
                new_node.next = self.head
            else:
                current = self.head
                while current.next != self.head:
                    current = current.next
                new_node.next = self.head
                current.next = new_node
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
        if self.size == 1:
            self.head = None
        elif index == 0:
            last = self.head
            while last.next != self.head:
                last = last.next
            self.head = self.head.next
            last.next = self.head
        else:
            current = self.head
            for _ in range(index - 1):
                current = current.next
            current.next = current.next.next
        self.size -= 1

    def remove(self, value):
        if not self.head:
            return False
        current = self.head
        prev = None
        while True:
            if current.data == value:
                if current == self.head:
                    self.remove_at(0)
                else:
                    prev.next = current.next
                    self.size -= 1
                return True
            prev = current
            current = current.next
            if current == self.head:
                break
        return False

# kullanım
cll = CircularSinglyLinkedList()
cll.add(1)
cll.add(2)
cll.add(3)
cll.print_list()  # 1 -> 2 -> 3 -> (back to head)
cll.insert_at(1, 1.5)
cll.print_list()  # 1 -> 1.5 -> 2 -> 3 -> (back to head)
cll.remove_at(2)
cll.print_list()  # 1 -> 1.5 -> 3 -> (back to head)
print(cll.get(1))  # 1.5
print(cll.index_of(3))  # 2
cll.remove(1.5)
cll.print_list()  # 1 -> 3 -> (back to head)
#headi göster
print(f"Head: {cll.tai}")  # Output: 1
#taili göster
