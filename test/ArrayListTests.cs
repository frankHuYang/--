namespace test;

public class ArrayListTests
{

    [Fact]
    public void Shoud_AddSix()
    {
        var al = Substitute.For<ArrayList>();
        al.Add(1);
        al.Add(2);
        al.Add(3);
        al.Add(4);
        al.Add(5);
        al.Add(6);
        al.Length.ShouldBe(6);
    }

    [Fact]
    public void Should_Insert_At_Fourth()
    {
        var al = Substitute.For<ArrayList>().ReceivedWithAnyArgs(5);
        al.Add(1);
        al.Add(2);
        al.Add(3);
        al.Add(4);
        al.Add(5);
        al.Insert(3, 5);
        al[3].ShouldBe(5);
        al[4].ShouldBe(4);
        al[5].ShouldBe(5);

    }

}