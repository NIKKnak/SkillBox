namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DZ1
            WorkWithList workWithList = new WorkWithList();
            
            List<int> myList = new List<int>();

            workWithList.FillList(myList);
            workWithList.PrintList(myList);
            workWithList.DelValue(myList);
            Console.WriteLine();
            Console.WriteLine();
            workWithList.PrintList(myList);
            #endregion DZ1


        }
    }
}
