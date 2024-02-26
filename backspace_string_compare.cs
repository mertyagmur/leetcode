// first solution
public bool BackspaceCompare(string s, string t) {
      Stack<char> characters1 = new();
      Stack<char> characters2 = new();

      foreach (char character in s)
      {
          if (character != '#')
          {
              characters1.Push(character);
          }
          else if (characters1.Count > 0)
          {
              characters1.Pop();
          }
      }

      foreach (char character in t)
      {
          if (character != '#')
          {
              characters2.Push(character);
          }
          else if (characters2.Count > 0) 
          {
              characters2.Pop();
          }
      }

      return string.Join("", characters1) == string.Join("", characters2);
  }
