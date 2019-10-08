using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;


namespace CustomList_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        
        

        [TestMethod]
        public void TestMethod1()
        {
        }



      // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // ADD METHODE TESTS // // // // //

        [TestMethod]
        public void Add_AddToEmptyList_ItemGoesToIndexZero()    
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 12;
            int actual;

            // act
            testList.Add(12);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemToList_CountIncrements()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;

            // act
            testList.Add(234);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddMultipleItemsToList_CheckLastIndex()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 123;
            int actual;

            // act
            testList.Add(234);
            testList.Add(872);
            testList.Add(222);
            testList.Add(123);
           
            actual = testList[3];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddMultipleItemsToList_CheckCount()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 4;
            int actual;

            // act
            testList.Add(234);
            testList.Add(872);
            testList.Add(222);
            testList.Add(123);
           
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // beyond capacisty but still adds
        public void Add_AddToListBeyondCapacity_CheckCount()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 5;
            int actual;

            // act
            testList.Add(234);
            testList.Add(872);
            testList.Add(222);
            testList.Add(123);
            testList.Add(110);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] 
        public void Add_AddToListBeyondCapacity_CheckIndex()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 110;
            int actual;

            // act
            testList.Add(234);
            testList.Add(872);
            testList.Add(222);
            testList.Add(123);
            testList.Add(110);
            actual = testList[4];

            // assert
            Assert.AreEqual(expected, actual);
        }


        // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // REMOVE METHODE TESTS // // // // //


        [TestMethod]
        public void Remove_RemoveValueFromStartOfList_ItemGoesToIndexZero()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 2;
            int actual;

            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Remove(1);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveIndexFromMiddleOfList_LastIndexGoesDown()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 3;
            int actual;

            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Remove(2);
            actual = testList[1];

            // assert
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void Remove_RemoveIndexFromList_CountDecrements()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 2;
            int actual;

            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Remove(1);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveMultipleItemsfromList_CheckFirstIndex()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 4;
            int actual;

            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Remove(1);
            testList.Remove(2);
            testList.Remove(3);


            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveMultipleItemsfromList_CheckCount()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;

            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Remove(1);
            testList.Remove(2);
            testList.Remove(3);


            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }


        // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // //  // // // // // GROW CAPACITY METHODE

        [TestMethod]
        public void GrowArray_ExceedStartCapacity_CapacityDoubles()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 8;
            int actual;

            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
          
         


            actual = testList.Capacity;

            // assert
            Assert.AreEqual(expected, actual);
        }






    }
}
