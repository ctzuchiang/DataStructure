using System.Text;

namespace DataStructure.StakeAndQueue
{
    public class MyCircularQueue : MyQueue
    {
        private int _Top;

        public MyCircularQueue(int maxSize): base(maxSize)
        {
            _Top = 0;
        }

        public new int GetCount()
        {
            return _Top;
        }

        public new bool Push(object key)
        {
            if (IsFull())
                return false;

            Rear = Rear % MaxSize;
            Queue[Rear++] = key;
            _Top++;

            return true;
        }

        public new object Pop()
        {
            if (IsEmpty())
                return null;

            Front = Front % MaxSize;
            _Top--;

            return Queue[Front++];
        }

        public new bool IsEmpty()
        {
            const int empty = 0;
            return _Top == empty ? true : false;
        }

        public new bool IsFull()
        {
            return _Top == MaxSize ? true : false;
        }

        public new string ItemToString()
        {
            StringBuilder result = new StringBuilder();

            int circularLength = Front + _Top;
            if (circularLength > MaxSize)
            {
                for (int i = Front; i < MaxSize; i++)
                {
                    result.Append(Queue[i]);
                }

                for (int i = 0; i < circularLength % MaxSize; i++)
                {
                    result.Append(Queue[i]);
                }
            }
            else
            {
                for (int i = Front; i < Front + _Top; i++)
                {
                    result.Append(Queue[i]);
                }
            }

            return result.ToString();
        }

    }
}
