using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue test = new Queue(10);
            test.push(5);
            test.push(2);
            test.push(3);
            test.push(5);
            test.pop();
            test.peak();
            Console.ReadLine();

        }
    }

    class Queue
    {
        private int[] array;
        private int rear;
        private int front;

        public Queue(int size)
        {
            this.array = new int[size];
            this.front = -1;
            this.rear = -1;
        }
        public void push(int item)
        {
            //prevents circular queue
            if (front <= rear)
            {
                array[rear + 1] = item;
                rear++;
            }
            else
            {
                Console.WriteLine("Circular queue would occur");
            }
        }

        public void pop()
        {
            array[front + 1] = 0;
            front++;
        }

        public void peak()
        {
            for (int i =0;i<array.Length;i++)
            {
                Console.Write(array[i] + ",");
            }
        }
    }
}
