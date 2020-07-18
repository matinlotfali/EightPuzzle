// Decompiled with JetBrains decompiler
// Type: Eight_Puzzle.State
// Assembly: Eight Puzzle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6FA4DB44-DF94-4839-B1FD-6E02A91C25D0
// Assembly location: C:\Users\matin\Desktop\Eight Puzzle.exe

using System;

namespace Eight_Puzzle
{
  internal class State
  {
    public State previusState;
    public LList nextStates;
    public char[,] data;
    public int f;
    public int g;

    public static bool isEqual(State a, State b)
    {
      for (int index1 = 0; index1 < 3; ++index1)
      {
        for (int index2 = 0; index2 < 3; ++index2)
        {
          if ((int) a.data[index1, index2] != (int) b.data[index1, index2])
            return false;
        }
      }
      return true;
    }

    public int heuristic
    {
      get
      {
        int num = 0;
        for (int index1 = 0; index1 < 3; ++index1)
        {
          for (int index2 = 0; index2 < 3; ++index2)
          {
            switch (this.data[index1, index2])
            {
              case '1':
                num += index1 + index2;
                break;
              case '2':
                num += Math.Abs(index1 - 1) + index2;
                break;
              case '3':
                num += 2 - index1 + index2;
                break;
              case '4':
                num += index1 + Math.Abs(index2 - 1);
                break;
              case '5':
                num += Math.Abs(index1 - 1) + Math.Abs(index2 - 1);
                break;
              case '6':
                num += 2 - index1 + Math.Abs(index2 - 1);
                break;
              case '7':
                num += index1 + 2 - index2;
                break;
              case '8':
                num += Math.Abs(index1 - 1) + 2 - index2;
                break;
            }
          }
        }
        return num;
      }
    }

    public override string ToString()
    {
      string str = "";
      for (int index1 = 0; index1 < 3; ++index1)
      {
        for (int index2 = 0; index2 < 3; ++index2)
          str = str + (object) this.data[index2, index1] + "\t";
        str += "\n";
      }
      return str;
    }

    public LList calculateNextStates()
    {
      if (this.nextStates == null)
      {
        this.nextStates = new LList();
        int x;
        int y;
        this.blank(out x, out y);
        if (x < 2)
        {
          State state = this.moveLeft(x, y);
          state.previusState = this;
          state.g = this.g + 1;
          this.nextStates.AddEnd(state);
        }
        if (y > 0)
        {
          State state = this.moveDown(x, y);
          state.previusState = this;
          state.g = this.g + 1;
          this.nextStates.AddEnd(state);
        }
        if (x > 0)
        {
          State state = this.moveRight(x, y);
          state.previusState = this;
          state.g = this.g + 1;
          this.nextStates.AddEnd(state);
        }
        if (y < 2)
        {
          State state = this.moveUp(x, y);
          state.previusState = this;
          state.g = this.g + 1;
          this.nextStates.AddEnd(state);
        }
      }
      return this.nextStates;
    }

    private void blank(out int x, out int y)
    {
      for (int index1 = 0; index1 < 3; ++index1)
      {
        for (int index2 = 0; index2 < 3; ++index2)
        {
          if (this.data[index1, index2] == ' ')
          {
            x = index1;
            y = index2;
            return;
          }
        }
      }
      throw new Exception("No blank found!");
    }

    private State moveLeft(int x, int y)
    {
      State state = new State();
      state.data = (char[,]) this.data.Clone();
      state.data[x, y] = this.data[x + 1, y];
      state.data[x + 1, y] = ' ';
      return state;
    }

    private State moveRight(int x, int y)
    {
      State state = new State();
      state.data = (char[,]) this.data.Clone();
      state.data[x, y] = this.data[x - 1, y];
      state.data[x - 1, y] = ' ';
      return state;
    }

    private State moveUp(int x, int y)
    {
      State state = new State();
      state.data = (char[,]) this.data.Clone();
      state.data[x, y] = this.data[x, y + 1];
      state.data[x, y + 1] = ' ';
      return state;
    }

    private State moveDown(int x, int y)
    {
      State state = new State();
      state.data = (char[,]) this.data.Clone();
      state.data[x, y] = this.data[x, y - 1];
      state.data[x, y - 1] = ' ';
      return state;
    }
  }
}
