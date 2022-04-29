namespace ReproNet6;
using System.Collections.Generic;

public class Good
{
    public List<string> TestList { get; }

    public void Run()
    {
        var x = TestList.Count; // Debugger breakpoint with condition 'TestList.' autocompletes OK with local using.
    }
}