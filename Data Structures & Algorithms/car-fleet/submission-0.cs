public class Solution
{
    public int CarFleet(int target, int[] position, int[] speed)
    {
        (int pos, int speed)[] cars = new (int pos, int speed)[position.Length];
        for (int i = 0; i < position.Length; i++)
        {
            cars[i] = (position[i], speed[i]);
        }        
        Array.Sort(cars, (a, b) => a.pos.CompareTo(b.pos));
        
        Stack<double> stack = new();
        
        for (int i = cars.Length - 1; i >= 0; i--)
        {
            double timeToTarget = (target - cars[i].pos) / (double)cars[i].speed;
            
            if (stack.Count == 0 || timeToTarget > stack.Peek())
            {
                stack.Push(timeToTarget);
            }
        }
        
        return stack.Count;
    }
}