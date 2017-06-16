using System.Collections.Generic;
using System.Text;

namespace DataStructure.StakeAndQueue
{
    public class MyStack
    {
        private readonly object[] _Stake;
        private readonly int _MaxSize;
        private int _Top;

        public MyStack(int maxSize)
        {
            _Stake = new object[maxSize];
            _MaxSize = _Stake.Length;
            _Top = 0;
        }

        public int GetSize()
        {
            return _MaxSize;
        }

        public int GetCount()
        {
            return _Top;
        }

        public bool Push(object key)
        {
            if (IsFull())
                return false;

            _Stake[_Top++] = key;
            return true;
        }

        public object Pop()
        {
            return IsEmpty() ? null : _Stake[--_Top];
        }

        public object Peek()
        {
            return IsEmpty() ? null : _Stake[_Top - 1];
        }

        public bool IsEmpty()
        {
            const int empty = 0;
            return _Top == empty ? true : false;
        }

        public bool IsFull()
        {
            return _Top == _MaxSize ? true : false;
        }

        public string ItemToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < _Top; i++)
            {
                result.Append(_Stake[i]);
            }

            return result.ToString();
        }

        public List<object> ItemToList()
        {
            return new List<object>(_Stake);
        }

    }
}
