// Decompiled with JetBrains decompiler
// Type: Eight_Puzzle.Agent
// Assembly: Eight Puzzle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6FA4DB44-DF94-4839-B1FD-6E02A91C25D0
// Assembly location: C:\Users\matin\Desktop\Eight Puzzle.exe

using System;

namespace Eight_Puzzle
{
  internal class Agent
  {
    public static bool working = false;
    public static State firstState;
    private static State _final;
    public static long counted;
    public static char[,] CReport;
    public static LList path;
    public static int pathlength;
    public static DateTime time;

    public static State finalState
    {
      get
      {
        if (Agent._final == null)
        {
          Agent._final = new State();
          Agent._final.data = new char[3, 3];
          char ch = '1';
          for (int index1 = 0; index1 < 3; ++index1)
          {
            for (int index2 = 0; index2 < 3; ++index2)
              Agent._final.data[index2, index1] = ch++;
          }
          Agent._final.data[2, 2] = ' ';
        }
        return Agent._final;
      }
    }

    public static void BFS()
    {
      Agent.counted = 0L;
      Agent.path = new LList();
      Agent.time = DateTime.Now;
      LList llist = new LList();
      llist.AddEnd(Agent.firstState);
      node node;
      for (node = llist.first; node != null && !State.isEqual(node.state, Agent.finalState); node = node.next)
      {
        llist.AddEndWithCheck(node.state.calculateNextStates());
        ++Agent.counted;
        Agent.CReport = (char[,]) node.state.data.Clone();
        Agent.pathlength = node.state.g;
      }
      if (node != null)
      {
        State state = node.state;
        do
        {
          Agent.path.AddFirst(state);
          state = state.previusState;
        }
        while (state != null);
      }
      Agent.working = false;
    }

    public static void UCS()
    {
      Agent.counted = 0L;
      Agent.path = new LList();
      Agent.time = DateTime.Now;
      LList llist = new LList();
      Agent.firstState.f = Agent.firstState.g;
      llist.AddEnd(Agent.firstState);
      State a = llist.first.state;
      while (a != null && !State.isEqual(a, Agent.finalState))
      {
        a = llist.GetMinF();
        for (node node = a.calculateNextStates().first; node != null; node = node.next)
        {
          node.state.f = node.state.g;
          llist.AddSorted(node.state);
        }
        ++Agent.counted;
        Agent.CReport = (char[,]) a.data.Clone();
        Agent.pathlength = a.g;
      }
      if (a != null)
      {
        State state = a;
        do
        {
          Agent.path.AddFirst(state);
          state = state.previusState;
        }
        while (state != null);
      }
      Agent.working = false;
    }

    public static void Greedy()
    {
      Agent.counted = 0L;
      Agent.path = new LList();
      Agent.time = DateTime.Now;
      LList llist = new LList();
      Agent.firstState.f = Agent.firstState.heuristic;
      llist.AddEnd(Agent.firstState);
      State a = llist.first.state;
      while (a != null && !State.isEqual(a, Agent.finalState))
      {
        a = llist.GetMinF();
        for (node node = a.calculateNextStates().first; node != null; node = node.next)
        {
          node.state.f = node.state.heuristic;
          llist.AddSorted(node.state);
        }
        ++Agent.counted;
        Agent.CReport = (char[,]) a.data.Clone();
        Agent.pathlength = a.g;
      }
      if (a != null)
      {
        State state = a;
        do
        {
          Agent.path.AddFirst(state);
          state = state.previusState;
        }
        while (state != null);
      }
      Agent.working = false;
    }

    public static void Astar()
    {
      Agent.counted = 0L;
      Agent.path = new LList();
      Agent.time = DateTime.Now;
      LList llist = new LList();
      Agent.firstState.f = Agent.firstState.heuristic + Agent.firstState.g;
      llist.AddEnd(Agent.firstState);
      State a = llist.first.state;
      while (a != null && !State.isEqual(a, Agent.finalState))
      {
        a = llist.GetMinF();
        for (node node = a.calculateNextStates().first; node != null; node = node.next)
        {
          node.state.f = node.state.heuristic + Agent.firstState.g;
          llist.AddSorted(node.state);
        }
        ++Agent.counted;
        Agent.CReport = (char[,]) a.data.Clone();
        Agent.pathlength = a.g;
      }
      if (a != null)
      {
        State state = a;
        do
        {
          Agent.path.AddFirst(state);
          state = state.previusState;
        }
        while (state != null);
      }
      Agent.working = false;
    }
  }
}
