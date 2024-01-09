public class MyQueue {
    public Stack s1= null;
    public Stack s2= null;
    public MyQueue() {
        s1 = new();
        s2 = new();
    }
    
    public void Push(int x) {
        s1.Push(x);
    }
    
    public int Pop() {
        if(s2.Count == 0) {
            while(s1.Count > 0) {
                s2.Push(s1.Pop());
            }
        }
        
        return (int)s2.Pop();
    }
    
    public int Peek() {
        if(s2.Count == 0) {
            while(s1.Count > 0) {
                s2.Push(s1.Pop());
            }
        }
        
        return (int)s2.Peek();
    }
    
    public bool Empty() {
        return (s1.Count + s2.Count) == 0; 
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */