namespace ReproNet6;

public class Bad
{
    public List<string> TestList { get; }

    public void Run()
    {
        var x = TestList.Count; // Debugger breakpoint with condition 'TestList.' doesn't autocomplete
    }
}