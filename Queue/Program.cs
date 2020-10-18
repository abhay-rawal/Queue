using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        public class Queue
        {
            int[] QueueArr;
            int front;
            int rear;
            int max;
            int i;
            public Queue(int size)
            {
                this.QueueArr = new int[size];
               this.front = 0;
                this.rear = -1;
                this.max = size;
            }
            public void enQueue(int item)
            {
                if(this.rear == this.max-1)
                {
                    Console.WriteLine("full");
                }
                else
                {
                    rear++;
                    QueueArr[rear] = item;
                    
                }
            }
            public void DeQuue()
            {
                if( this.front == rear+1 )
                {
                    Console.WriteLine("empty");
                }
                else
                {
                    Console.WriteLine("Deleted From the Queue {0}", QueueArr[rear]);
                    front++;
                }
            }
            public void Print()
            {
                for(i=front;i<=rear;i++)
                {
                    Console.WriteLine(QueueArr[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Queue One = new Queue(5);
            One.enQueue(1);
            One.enQueue(2);
            One.Print();
            
        }
    }
}
