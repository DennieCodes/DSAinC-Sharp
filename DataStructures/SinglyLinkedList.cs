namespace DataStructuresAndAlgorithms.DataStructures;

public class Node
{
    public Object Data { get; set; } // Fix: Remove 'required' keyword
    public Node? next { get; set; } = null;

    public Node(object data)
    {
        this.Data = data;
    }
}

public class SinglyLinkedList
{
    public Node? head;
    public Node? tail;
    public int count { get; set; }

    public SinglyLinkedList()
    {
        this.head = null;
        this.tail = null;
        this.count = 0;
    }

    public void Append(Object value)
    {
        var newNode = new Node(value);

        if (this.head == null)
        {
            this.head = newNode;
        }
        else
        {
            var lastNode = FindLastNode();
            lastNode.next = newNode;
        }

        this.count += 1;
    }

    public Node FindLastNode()
    {
        var current = this.head;

        while (current?.next != null)
        {
            current = current.next;
        }

        return current;
    }
}
