namespace test
{
    public class BubblingSortTests
    {

        [Fact]
        public void Should_Work_Normally()
        {

            var a = new int[] { 7, 8, 5, 9, 0, 3, 2, 6, 4, 1 };
            var s = Substitute.For<BubblingSort>();
            s.Sort(a);
            a[0].ShouldBe(0);
            a[1].ShouldBe(1);
            a[2].ShouldBe(2);
            a[3].ShouldBe(3);
            a[4].ShouldBe(4);
            a[5].ShouldBe(5);
            a[6].ShouldBe(6);
            a[7].ShouldBe(7);
            a[8].ShouldBe(8);
            a[9].ShouldBe(9);
        }

        [Fact]
        public void CompareTimes_ShouldBe5_And_ExchangeTimes_ShouldBe0()
        {
            // Given
            var a = new int[] { 1, 2, 3, 4, 5, 6 };
            var s = Substitute.For<BubblingSort>();
            // When
            var r = s.Sort(a);
            // Then
            r.CompareTimes.ShouldBe(5);
            r.ExchangeTimes.ShouldBe(0);
        }

        [Fact]
        public void CompareTimes_ShouldBe9_And_ExchangeTimes_ShouldBe1()
        {
            // Given
            var a = new int[] { 2, 1, 3, 4, 5, 6 };
            var s = Substitute.For<BubblingSort>();
            // When
            var r = s.Sort(a);
            // Then
            r.CompareTimes.ShouldBe(9);
            r.ExchangeTimes.ShouldBe(1);
        }
        
        [Fact]
        public void CompareTimes_ShouldBe12_And_ExchangeTimes_ShouldBe2()
        {
            // Given
            var a = new int[] { 3, 2, 1, 4, 5, 6 };
            var s = Substitute.For<BubblingSort>();
            // When
            var r = s.Sort(a);
            // Then
            r.CompareTimes.ShouldBe(12);
            r.ExchangeTimes.ShouldBe(2);
        }
        [Fact]
        public void CompareTimes_ShouldBe14_And_ExchangeTimes_ShouldBe3()
        {
            // Given
            var a = new int[] { 2, 1, 3, 4, 5, 6 };
            var s = Substitute.For<BubblingSort>();
            // When
            var r = s.Sort(a);
            // Then
            r.CompareTimes.ShouldBe(9);
            r.ExchangeTimes.ShouldBe(1);
        }
        [Fact]
        public void CompareTimes_ShouldBe15_And_ExchangeTimes_ShouldBe4()
        {
            // Given
            var a = new int[] { 2, 1, 3, 4, 5, 6 };
            var s = Substitute.For<BubblingSort>();
            // When
            var r = s.Sort(a);
            // Then
            r.CompareTimes.ShouldBe(9);
            r.ExchangeTimes.ShouldBe(1);
        }


    }
}