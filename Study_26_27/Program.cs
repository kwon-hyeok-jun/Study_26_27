using System;
using System.Collections;

class ExceptionHandling
{
    static void Main()
    {
        /*
        Stack stack = new Stack();

        try
        {
            stack.Push("First");
            stack.Push("Second");
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
        var queue = new Queue();

        queue.Enqueue(19);
        queue.Enqueue(20);
        queue.Enqueue(30);

        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Dequeue());
        */
        Hashtable hash = new Hashtable();
        hash[0] = "dot";
        hash["닉네임"] = "레스";
        hash["닉"] = "파랑";

        foreach (object o in hash.Keys)
        {
            Console.WriteLine(hash[o]);
            Console.WriteLine(o);
        }
    }

}