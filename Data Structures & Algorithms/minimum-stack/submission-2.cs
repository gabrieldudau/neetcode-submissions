public class MinStack {

    private int min;
    private Stack<long> internEncodedStack;

    public MinStack() {
        this.internEncodedStack = new();
    }
    
    public void Push(int val) {
        if (internEncodedStack.Count == 0)
        {
            internEncodedStack.Push(0L);
            min = val;
        }
        else
        {
            long toPush = (long) val - min;
            internEncodedStack.Push(toPush);
            if(val < min) min = val;
        }
    }
    
    public void Pop() {
        if (internEncodedStack.Count == 0) return;
        long pop = internEncodedStack.Pop();
        if (pop < 0) min -= (int) pop;
    }
    
    public int Top() {
        long peek = internEncodedStack.Peek();
        return peek < 0 ? min : (int) (peek + min);
    }
    
    public int GetMin() {
        return min;
    }
}
