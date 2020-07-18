// Decompiled with JetBrains decompiler
// Type: Eight_Puzzle.LList
// Assembly: Eight Puzzle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6FA4DB44-DF94-4839-B1FD-6E02A91C25D0
// Assembly location: C:\Users\matin\Desktop\Eight Puzzle.exe

namespace Eight_Puzzle
{
  internal class LList
  {
    public node first;
    public node last;

    public void AddEnd(node node)
    {
      node.next = (node) null;
      if (this.last == null)
      {
        this.last = node;
        this.first = node;
      }
      else
      {
        this.last.next = node;
        node.previus = this.last;
        this.last = node;
      }
    }

    public void AddEnd(State state)
    {
      this.AddEnd(new node() { state = state });
    }

    public void AddFirst(State state)
    {
      node node = new node();
      node.state = state;
      if (this.first == null)
      {
        this.last = node;
        this.first = node;
      }
      else
      {
        node.next = this.first;
        this.first.previus = node;
        this.first = node;
      }
    }

    public void AddEndWithCheck(LList list)
    {
      node next;
      for (node node = list.first; node != null; node = next)
      {
        next = node.next;
        if (!this.isExist(node.state))
          this.AddEnd(node);
      }
    }

    public void AddSorted(State state)
    {
      node node1 = new node();
      node1.state = state;
      if (this.first == null)
      {
        this.AddEnd(state);
      }
      else
      {
        node node2 = this.first;
        node node3 = (node) null;
        for (; node2 != null; node2 = node2.next)
        {
          if (node2.state.f >= state.f && node3 == null)
            node3 = node2;
          if (State.isEqual(node2.state, state))
          {
            if (node2.state.f <= state.f)
              return;
            node2.previus.next = node2.next;
            node2.next.previus = node2.previus;
            break;
          }
        }
        if (node3 == null && node2 == null)
        {
          node1.previus = this.last;
          this.last.next = node1;
          this.last = node1;
        }
        else if (node3 == this.first)
        {
          node1.next = this.first;
          this.first.previus = node1;
          this.first = node1;
        }
        else
        {
          node1.next = node3;
          node1.previus = node3.previus;
          node3.previus.next = node1;
        }
      }
    }

    public State GetMinF()
    {
      for (node node = this.first; node != null; node = node.next)
      {
        if (!node.visited)
        {
          node.visited = true;
          return node.state;
        }
      }
      return (State) null;
    }

    public bool isExist(State state)
    {
      for (node node = this.first; node != null; node = node.next)
      {
        if (State.isEqual(node.state, state))
          return true;
      }
      return false;
    }
  }
}
