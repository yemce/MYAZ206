using ValueAndReferenceTypes;
using Xunit;

namespace ValueAndReferenceTypesTests
{
    public class ValAndRefTypesTests
    {
        [Fact]
        public void RefTypeTests()
        {

            //Arrange Düzenleme
            var p1 = new RefType()
            {
                X = 10,
                Y = 20
            };
            var p2 = p1;

            //Act Eylem
            p1.X = 30;

            //Assert

            Assert.Equal(p1.X, p2.X);
        }


        [Fact]
        public void ValTypeTests()
        {

            //Arrange Düzenleme
            var p1 = new ValueType()
            {
                X = 10,
                Y = 20
            };
            var p2 = p1;

            //Act Eylem
            p1.X = 30;

            //Assert

            Assert.NotEqual(p1.X, p2.X);
        }

        [Fact]
        
        public void RecordTypeTests()
        {
            //Arrange
            var p1 = new RecordType(3,5);

            //Act

            var p2 = new RecordType(3,5);

            //Assert

            Assert.Equal(p1, p2);
        }

        [Fact]

        public void SwapByVal()
        {
            // Arrange

            int a = 23, b = 50;

            var valType = new ValueType();

            //Act
            valType.Swap(a, b);

            //Assert
            Assert.NotEqual(a, 50);
            Assert.NotEqual(b, 23);

        }

        [Fact]

        public void SwapByRef()
        {
            //Arrange

            int a = 23, b = 50;

            var refType = new RefType();

            //Act

            refType.Swap(ref a, ref b);

            //Asssert

            Assert.Equal(a, 50);
            Assert.Equal(b,23);
        }

        [Fact]

        public void CheckOutKeyword()
        {
            //Arrange
            var refType = new RefType();

            int b = 50;

            //Act
            refType.CheckOut(out b);

            //Assert
            Assert.Equal(b,100);
        }
    }
}