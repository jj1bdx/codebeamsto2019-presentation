using System;
using System.Collections.Generic;

namespace Wandbox {
  class Program {
    static void Main(string[] args) {
      int i = 100;
      List<int> a = new List<int>(){10, 20};
      MutableMethod(i, a);
      Console.WriteLine(string.Format("i = {0}, a = {1}",
                                      i,
                                      ConvertListToString(a)));
    }
    static string ConvertListToString(List<int> list) {
      return "{" + string.Join( ",", list) + "}";
    }
    static void MutableMethod(int i, List<int> a) {
      i = 200;
      a.Add(30);
    }
  }
}
