class Queue():
    def __init__(self):
        self.elements = []
        
        
    def isEmpty(self):
        return self.elements == []
    
    def enqueue(self, item):
        self.elements.append(item)
        
    def dequeue(self):
        return self.elements.pop(0)
    
    def size(self):
        return len(self.elements)
    
    def showFirst(self):
        return self.elements[0]
    
    
    
myQueue = Queue()
myQueue.enqueue(1)
myQueue.enqueue(2)
myQueue.enqueue(3)
myQueue.enqueue(4)

myQueue.dequeue()


result = myQueue.size()
result = myQueue.showFirst()
result= myQueue.isEmpty()

print(result)

