// Decompiled with JetBrains decompiler
// Type: Eight_Puzzle.CostList
// Assembly: Eight Puzzle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6FA4DB44-DF94-4839-B1FD-6E02A91C25D0
// Assembly location: C:\Users\matin\Desktop\Eight Puzzle.exe

using System.Collections.Generic;

namespace Eight_Puzzle
{
  internal class CostList
  {
    private List<State> states;
    private List<int> costs;
    private List<bool> visited;

    public CostList()
    {
      this.states = new List<State>();
      this.costs = new List<int>();
      this.visited = new List<bool>();
    }

    public int Count
    {
      get
      {
        return this.states.Count;
      }
    }

    public void Add(State state, int cost)
    {
      for (int index = 0; index < this.Count; ++index)
      {
        if (State.isEqual(this.states[index], state))
        {
          if (this.costs[index] <= cost)
            return;
          this.costs[index] = cost;
          this.states[index] = state;
          this.SortByCost();
          return;
        }
      }
      this.states.Add(state);
      this.costs.Add(cost);
      this.visited.Add(false);
      this.SortByCost();
    }

    private void SortByCost()
    {
      for (int index1 = 0; index1 < this.Count; ++index1)
      {
        for (int index2 = index1; index2 < this.Count - 1; ++index2)
        {
          if (this.costs[index2] > this.costs[index2 + 1])
          {
            State state = this.states[index2];
            int cost = this.costs[index2];
            bool flag = this.visited[index2];
            this.states[index2] = this.states[index2 + 1];
            this.costs[index2] = this.costs[index2 + 1];
            this.visited[index2] = this.visited[index2 + 1];
            this.states[index2 + 1] = state;
            this.costs[index2 + 1] = cost;
            this.visited[index2 + 1] = flag;
          }
        }
      }
    }

    public void Delete(out State state, out int cost)
    {
      int index = 0;
      while (index < this.states.Count && this.visited[index])
        ++index;
      state = this.states[index];
      cost = this.costs[index];
      this.visited[index] = true;
    }
  }
}
