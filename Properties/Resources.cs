// Decompiled with JetBrains decompiler
// Type: Eight_Puzzle.Properties.Resources
// Assembly: Eight Puzzle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6FA4DB44-DF94-4839-B1FD-6E02A91C25D0
// Assembly location: C:\Users\matin\Desktop\Eight Puzzle.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Eight_Puzzle.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (Eight_Puzzle.Properties.Resources.resourceMan == null)
          Eight_Puzzle.Properties.Resources.resourceMan = new ResourceManager("Eight_Puzzle.Properties.Resources", typeof (Eight_Puzzle.Properties.Resources).Assembly);
        return Eight_Puzzle.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return Eight_Puzzle.Properties.Resources.resourceCulture;
      }
      set
      {
        Eight_Puzzle.Properties.Resources.resourceCulture = value;
      }
    }
  }
}
