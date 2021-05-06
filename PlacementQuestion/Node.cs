using System;

public class Node
{
    public int val;
    public Node Next;
	public Node()
	{
	}
    public Node(int _val)
    {
        this.val = _val;
        this.Next = null;
    }
    public Node(int _val, Node _next)
    {
        this.val = _val;
        this.Next = _next;
    }
}
