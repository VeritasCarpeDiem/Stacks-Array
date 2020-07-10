using System;
using System.Collections;

using Stacks;
using Xunit;

namespace Stacks.Tests
{
    public class StackTests
    {
        [Fact]
        public void TestForEmptyStack()
        {
            ArrayStack<int> stack = new ArrayStack<int>();

            Assert.Equal(0, stack.Count);
            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void TestForPushCountIncreasing()
        {
            ArrayStack<int> stack = new ArrayStack<int>();
            stack.Push(5);

            Assert.Equal(1, stack.Count);
            Assert.True(stack.Peek() == 5);

        }

        [Theory]
        [InlineData(0, true)]
        [InlineData(3, false)]
        [InlineData(5, false)]
        [InlineData(100, false)]
        [InlineData(1, false)]
        [InlineData(10000, false)]

        public void TestForStackAfterCountPushes(int count, bool expected)
        {
            ArrayStack<int> stack = new ArrayStack<int>();

            for (int i = 0; i < count; i++)
            {
                stack.Push(i);
            }

            Assert.Equal(expected, stack.IsEmpty());
            Assert.Equal(count, stack.Count);
        }

       [Theory]

       public void Test(int number, int  )
        {
            ArrayStack<int> stack = new ArrayStack<int>();

            for(int i=0; i >stack.Count-1; i--)
            {

            }
        }

        [Fact]
        public void TestForIsFiveLessThanZero()
        {
            bool result = IsLessThanZero(5);

            Assert.False(result);
        }

        [Fact]
        public void TestForPositiveNumbersReturningFalse()
        {
            for (int i = 0; i < 10; i++)
            {
                Assert.False(IsLessThanZero(i));
            }
        }

        [Fact]
        public void TestForNegativeNumbersReturningTrue()
        {
            for (int i = -10; i < 0; i++)
            {
                Assert.True(IsLessThanZero(i));
            }
        }


        [Theory]
        [InlineData(0, false)]
        [InlineData(5, false)]
        [InlineData(-5, true)]
        [InlineData(int.MaxValue, false)]
        [InlineData(int.MinValue, true)]
        public void TestForLessThanZeroWorksForPositiveAndNegativeValues(int num, bool expected)
        {
            Assert.Equal(expected, IsLessThanZero(num));

        }


        bool IsLessThanZero(int num)
        {
            if (num < 0)
            {
                return true;
            }

            return false;
        }
    }
}
