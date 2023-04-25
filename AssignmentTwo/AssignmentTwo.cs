using System;
using System.Collections.Generic;

class Branch {
    public List<Branch> branches = new List<Branch>();
}

class Program {
    List<Branch> branches;
    static int CalculateDepth(Branch branch) {
        int maxDepth = 0;
        foreach (var item in branch.branches) {
            int itemDepth = CalculateDepth(item);
            maxDepth = Math.Max(maxDepth, itemDepth);
        }
        return maxDepth + 1;
    }

    static void Main(string[] args) {
        var root = new Branch();
        var branches1 = new Branch();
        var branches2 = new Branch();
        var branches3 = new Branch();
        var branches4 = new Branch();

        root.branches.Add(branches1);
        branches1.branches.Add(branches2);
        branches2.branches.Add(branches3);
        branches3.branches.Add(branches4);

        int depth = CalculateDepth(root);
        Console.WriteLine($"The depth of the structure is {depth}.");
    }
}
