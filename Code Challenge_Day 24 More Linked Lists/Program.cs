using System;

namespace Code_Challenge_Day_24_More_Linked_Lists
{
    class Program
    {
		public static Node RemoveDuplicates(Node head)
		{
			Node result = new Node(head.data);
			Node temp = new Node(head.data);
			while(head != null)
            {
				if(head.data != temp.data)
                {
					temp = new Node(head.data);
					result = Insert(result, head.data);
                }
				head = head.next;
            }

			return result;

		}
		public static Node Insert(Node head, int data)
		{
			Node p = new Node(data);

			if (head == null)
				head = p;
			else if (head.next == null)
				head.next = p;
			else
			{
				Node start = head;
				while (start.next != null)
					start = start.next;
				start.next = p;

			}
			return head;
		}
		public static void display(Node head)
		{
			Node start = head;
			while (start != null)
			{
				Console.Write(start.data + " ");
				start = start.next;
			}
		}
		static void Main(String[] args)
		{

			Node head = null;
			int T = Int32.Parse(Console.ReadLine());
			while (T-- > 0)
			{
				int data = Int32.Parse(Console.ReadLine());
				head = Insert(head, data);
			}
			head = RemoveDuplicates(head);
			display(head);
		}
	}
}
