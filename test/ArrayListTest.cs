using algorithim.array;
using Shouldly;

namespace test;

public class ArrayListTest
{

    [Fact]
    public void ShoudAddSix()
    {
        var al = new ArrayList(5);
        al.Add(1);
        al.Add(2);
        al.Add(3);
        al.Add(4);
        al.Add(5);
        al.Add(6);
        al.Length.ShouldBe(6);
    }
}