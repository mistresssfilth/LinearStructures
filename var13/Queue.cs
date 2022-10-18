class Queue
{
  private List<int> queue;
  private static int count = 0;

  public Queue() { queue = new List<int>(); }
  public void clear() => queue.Clear();
  public int getCount() => count;

  public void push(int value) { 
    queue.Add(value); 
    count++;
  }
  public int pop()
  {
    int first = queue[0];
    removeByIndex(first);
    return first;
  }
  public void removeByIndex(int index)
  {
    for (int i = 0; i < index; i++)
      push(pop());
    
    removeByIndex(queue[0]);
    
    for (int i = index; i < getCount(); i++)
      push(pop());
  }
  public int getByIndex(int index)
  {
    for (int i = 0; i < index; i++)
      push(pop());

    int value = queue[0];

    for (int i = index; i < getCount(); i++)
      push(pop());

    return value;
  }
}
