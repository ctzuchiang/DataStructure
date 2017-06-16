namespace DataStructure.LinkedList
{
    public class MyNode
    {
        public string Data { get; set; }
        public MyNode NextNode;
        public MyNode PreviousNode;

        public void NodeSwitch()
        {
            MyNode tempNode = PreviousNode;
            PreviousNode = NextNode;
            NextNode = tempNode;
        }

        public void RemoveNode()
        {
            Data = null;
            NextNode = null;
            PreviousNode = null;
        }
    }
}