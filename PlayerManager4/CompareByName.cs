using System;
using System.Collections.Generic;

public class CompareByName : IComparer<Player>
{
    private readonly bool ascending;

    public CompareByName(bool ascending)
    {
        this.ascending = ascending;
    }

    public int Compare(Player x, Player y)
    {
        // Compare players based on their names
        int result = string.Compare(x.Name, y.Name);

        if (!ascending)
        {
            // Reverse the comparison result for descending order
            result = -result;
        }

        return result;
    }
}
