using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test
{
    public class InsertionSortTests
    {


        [Fact]
        public void Should_Work_Normally()
        {
            // Given    5,4,3,2,1  4,5,3,2,1  3,4,5,2,1   2,3,4,5,1   1,2,3,4,5
            var a = new int[] { 4, 3, 5, 2, 1 };
            // When
            var s = Substitute.For<InsertionSort>();
            s.Sort(a);
            // Then
           a[0].ShouldBe(1);
           a[1].ShouldBe(2);
           a[2].ShouldBe(3);
           a[3].ShouldBe(4);
           a[4].ShouldBe(5);

        }

    }
}