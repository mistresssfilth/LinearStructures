class Sort
{
  private Queue queue;
  public Sort()
  {
    queue = new Queue();
  }
  public void fill(int count)
  {
    Random random = new Random();
    for (int i = 0; i < count; i++)
    {
      int value = random.Next() % 999;
      queue.push(value);
    }
  }
  public void sorting()
  {
    int step = queue.getCount() / 2;
    while (step > 0)
    {
      for(int i = step; i < queue.getCount(); i++)
      {
        for(int j = i; j >= step; j -= step)
        {
          if (queue.get(j - step) > queue.get(j))
          {
            int temp = queue.get(j);
            queue.set(j, queue.get(j - step));
            queue.set(j - step, temp);
          }
          else break;
        }
      }
      step /= 2;
    }

  }
  public void print()
  {
    foreach (int i in queue.getElem())
      Console.Write(i + " ");
  }

}