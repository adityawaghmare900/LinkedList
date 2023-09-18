namespace InsertAtOnePosition_UC4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list=new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            Console.WriteLine("=============================================");
            int a = list.Search(30);
            Console.WriteLine("index position of element 30 is : " + a);
            list.InsertAtPerticularPostion(a+1, 40);
            Console.WriteLine("=============================================");
            list.Display();

        }
    }
}