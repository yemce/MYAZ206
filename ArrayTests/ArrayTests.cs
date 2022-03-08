using DataStructures.Array;
using System.Collections.Generic;
using Xunit;

namespace ArrayTests
{
    public class ArrayTests
    {
        [Theory]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(64)]
        [InlineData(128)]
        [InlineData(256)]

        public void Check_Array_Constructor(int defaultSize)
        {
            //Arrange - Act
            var arr = new Array(defaultSize);

            //Assert
            Assert.Equal(defaultSize, arr.Length);
        }

        [Fact]

        public void Chech_Array_Constructor_with_params()
        {
            //Arrange & Act

            var array = new DataStructures.Array.Array(1,2,3);

            //Assert
            Assert.Equal(3,array.Length);
        }

        [Fact]

        public void Get_and_Set_Values_in_Array()
        {
            //Arrange
            var array = new DataStructures.Array.Array();

            //Act
            array.SetValue(10, 0);
            array.SetValue(20, 1);

            //Assert
            Assert.Equal(array.GetValue(0),10);
            Assert.Null(array.GetValue(2));

        }

        [Fact]

        public void Array_Clone_Tests()
        {
            //Arrange

            var array = new DataStructures.Array.Array(1, 2, 3);

            //Act

            var clonedArray = array.Clone() as DataStructures.Array.Array;

            //Assert

            Assert.NotNull(clonedArray);
            Assert.Equal(array.Length, clonedArray.Length);
            Assert.NotEqual(array.GetHashCode(), clonedArray.GetHashCode());
        }

        [Fact]

        public void Array_Custom_GetEnumerator_Test()   
        {
            //Arrange
            var array = new DataStructures.Array.Array(10, 20, 30);

            //Act
            string s = "";

            foreach (var item in array)
            {
                s += item;
            }

            //Assert
            Assert.Equal(s,"102030");
        }
    }
}