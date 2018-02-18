using System.Data;
using Xunit;

namespace ConsoleApp1
{
    public class Testing
    {
        Program checker = new Program();
        [Fact]
        public static void PassingTest()
        {
            int[] array = new int[3];
            array[0] = 3;
            array[1] = 7;
            array[2] = 5;
            Assert.Equal(2, Reader.CheckInput(array, true));
        }

        [Fact]
        public static void FailingTest()
        {
            int[] array = new int[3];
            array[0] = 3;
            array[1] = 7;
            array[2] = 5;
            Assert.Equal(2, Reader.CheckInput(array, true));
        }

    }
}