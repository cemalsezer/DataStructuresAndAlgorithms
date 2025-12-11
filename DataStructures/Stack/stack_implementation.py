class Stack():
    def __init__(self):
        self.elements = []
    
    def isEmpty(self):
        return self.elements == []
    
    def push(self, item):
        self.elements.append(item)
        
    def pop(self):
            self.elements.pop()
            
    def showLast(self):
       return self.elements[-1]
   
    def size(self):
        return len(self.elements)
    
myStack = Stack()
myStack.push(1)
myStack.push(2)
myStack.push(3)
myStack.push(4)
myStack.pop()







result = myStack.showLast()  

print(result)  