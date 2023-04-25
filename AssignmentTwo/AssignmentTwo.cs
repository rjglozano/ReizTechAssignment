using System;
using System.Collections.Generic;

class Branch
{
    public string Name { get; set; }
    public List<Branch> Branches { get; set; }

    public Branch(string name)
    {
        Name = name;
        Branches = new List<Branch>();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Branch root = CreateStructure(5);
        int depth = CalculateDepth(root);
        Console.WriteLine($"Depth of structure: {depth}");
    }

    static Branch CreateStructure(int depth)
    {
        if (depth == 0)
        {
            return new Branch("leaf");
        }
        else
        {
            Branch branch = new Branch($"branch{depth}");
            branch.Branches.Add(CreateStructure(depth - 1));
            return branch;
        }
    }

    static int CalculateDepth(Branch branch)
    {
        if (branch.Branches.Count == 0)
        {
            return 1;
        }
        else
        {
            int maxDepth = 0;
            foreach (Branch subbranch in branch.Branches)
            {
                int subDepth = CalculateDepth(subbranch);
                if (subDepth > maxDepth)
                {
                    maxDepth = subDepth;
                }
            }
            return maxDepth + 1;
        }
    }
}
