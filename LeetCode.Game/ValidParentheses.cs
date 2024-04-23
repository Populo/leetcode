namespace LeetCode.Game;

public partial class Puzzles {
    
    public static bool ValidParentheses(string input)
    {
        Stack<char> stack = new Stack<char>();
        
        foreach(var c in input)
        {
            if (stack.Count == 0)
            {
                stack.Push(c);
                continue;
            }
            
            var last = stack.Peek();
            switch (c)
            {
                case ')':
                    if (last != '(') return false;
                    stack.Pop();
                    break;
                case ']':
                    if (last != '[') return false;
                    stack.Pop();
                    break;
                case '}':
                    if (last != '{') return false;
                    stack.Pop();
                    break;
                default:
                    stack.Push(c);
                    break;
            }
        }
        
        return stack.Count == 0;
    }
}