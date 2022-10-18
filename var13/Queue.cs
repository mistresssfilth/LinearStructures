using System.Collections;
using System.Collections.Generic;

class Queue
{
  private List<int> queue;

  public Queue() { queue = new List<int>(); }
  public void clear() => queue.Clear();
  public int getCount() => queue.Count();

  public void push(int value) { 
    queue.Add(value); 
  }
  public int pop()
  {
    int first = queue[0];
    queue.Remove(first);
    return first;
  }
  public void removeByIndex(int index)
  {
    for (int i = 0; i < index; i++)
      push(pop());
    
    queue.Remove(queue[0]);
    
    for (int i = index; i < getCount(); i++)
      push(pop());
  }
  public int get(int index)
  {
    for (int i = 0; i < index; i++)
      push(pop());

    int value = queue[0];

    for (int i = index; i < getCount(); i++)
      push(pop());

    return value;
  }
  public void set(int index, int value)
  {
    for (int i = 0; i < index; i++)
      push(pop());

    queue[0] = value;

    for (int i = index; i < getCount(); i++)
      push(pop());

  }
  public IEnumerable getElem()
  {
    for(int i = 0;i < getCount();i++)
      yield return queue[i];
  }
 
}
