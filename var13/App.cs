class App
{
  static void Main(string[] args)
  {
    Sort sort = new Sort();
    sort.fill(10);
    sort.print();
    Console.WriteLine();
    sort.sorting();
    sort.print();
  }

}
