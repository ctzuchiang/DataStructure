using System.Text;

namespace DataStructure.LinkedList
{
    public class MyLinkList
    {
        public int Count
        {
            get { return NodeCount(); }
        }

        private MyNode _FirstNode;
        private MyNode _LastNode;

        public MyLinkList()
        {
            _LastNode = new MyNode();
            _FirstNode = _LastNode;
        }

        public void Add(string data)
        {
            _LastNode.Data = data;
            _LastNode.NextNode = new MyNode() { PreviousNode = _LastNode };
            if (IsNodeEmpty())
            {
                _FirstNode = _LastNode;
            }
            _LastNode = _LastNode.NextNode;
        }

        public void AddAtStart(string data)
        {
            MyNode curNode = _FirstNode;
            _FirstNode = new MyNode() { Data = data, NextNode = curNode };
            _FirstNode.NextNode.PreviousNode = _FirstNode;
        }

        public void RemoveFirst()
        {
            _FirstNode = _FirstNode.NextNode;
            _FirstNode.PreviousNode = null;
        }

        public void RemoveLast()
        {
            MyNode curNode = _FirstNode;
            while (!IsLastNode(curNode))
            {
                _LastNode = curNode;
                curNode = curNode.NextNode;
            }
            _LastNode.Data = null;
            _LastNode.NextNode = null;
        }

        public void Remove(string data)
        {
            MyNode curNode = _FirstNode;
            while (!IsLastNode(curNode) && curNode.Data != data)
            {
                curNode = curNode.NextNode;
            }

            curNode.PreviousNode.NextNode = curNode.NextNode;
            curNode.NextNode.PreviousNode = curNode.PreviousNode;
        }

        private int NodeCount()
        {
            int count = 0;

            MyNode curNode = _FirstNode;
            while (curNode.NextNode != null)
            {
                count++;
                curNode = curNode.NextNode;
            }

            return count;
        }

        private bool IsLastNode(MyNode curNode)
        {
            return curNode.NextNode == null;
        }

        private bool IsNodeEmpty()
        {
            return _FirstNode.Data == null && _FirstNode.NextNode == null;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            MyNode curNode = _FirstNode;
            while (curNode.NextNode != null)
            {
                sb.Append(curNode.Data);
                curNode = curNode.NextNode;
            }
            return sb.ToString();
        }

        public void Invert()
        {
            MyNode curNode = _FirstNode;
            MyNode nxtNode = curNode.NextNode;

            while (!IsLastNode(nxtNode))
            {
                curNode.NodeSwitch();
                curNode = nxtNode;
                nxtNode = curNode.NextNode;
            }

            curNode.NodeSwitch();
            SwitchFirstAndLast();
        }

        private void SwitchFirstAndLast()
        {
            MyNode tempNode = _FirstNode;

            _FirstNode = _LastNode.PreviousNode;
            _LastNode.PreviousNode = tempNode;

            tempNode = _FirstNode.PreviousNode;
            _FirstNode.PreviousNode = _LastNode.PreviousNode.NextNode;
            _LastNode.PreviousNode.NextNode = tempNode;
        }

        public void Concatenate(MyLinkList list)
        {
            _LastNode.PreviousNode.NextNode = list._FirstNode;
            list._FirstNode.PreviousNode = _LastNode.PreviousNode;
            _LastNode = list._LastNode;
        }

        public void RemoveAll()
        {
            MyNode curNode = _FirstNode;
            MyNode nxtNode = curNode.NextNode;

            while (!IsLastNode(nxtNode))
            {
                curNode.RemoveNode();
                curNode = nxtNode;
                nxtNode = curNode.NextNode;
            }
            curNode.RemoveNode();
            _FirstNode = _LastNode;
            _FirstNode.PreviousNode = null;
        }

        public bool IsContain(string key)
        {
            MyNode curNode = _FirstNode;
            while (curNode.NextNode != null)
            {
                if (curNode.Data == key)
                {
                    return true;
                }
                curNode = curNode.NextNode;
            }
            return false;
        }
    }
}
