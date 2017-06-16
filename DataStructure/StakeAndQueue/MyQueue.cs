using System.Text;

namespace DataStructure.StakeAndQueue
{
    public class MyQueue
    {
        internal readonly object[] Queue;
        internal readonly int MaxSize;
        internal int Front;
        internal int Rear;

        public MyQueue(int maxSize)
        {
            Queue = new object[maxSize];
            MaxSize = Queue.Length;
            Front = 0;
            Rear = 0;
        }

        public int GetSize()
        {
            return MaxSize;
        }

        public int GetCount()
        {
            return Rear;
        }

        public bool Push(object key)
        {
            if (IsFull())
                return false;

            Queue[Rear++] = key;
            return true;
        }

        public object Pop()
        {
            if (IsEmpty())
                return null;

            var firstQueue = Queue[0];

            for (int i = 0; i < Rear; i++)
            {
                if (i + 1 == MaxSize)
                {
                    Queue[i] = null;
                    break;
                }
                Queue[i] = Queue[i + 1];
            }

            Rear--;
            return firstQueue;
        }

        public bool IsEmpty()
        {
            const int empty = 0;
            return Rear == empty ? true : false;
        }

        public bool IsFull()
        {
            return Rear == MaxSize ? true : false;
        }

        public string ItemToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < Rear; i++)
            {
                result.Append(Queue[i]);
            }

            return result.ToString();
        }
    }


}
