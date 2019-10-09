﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace UnitTestV2
{
    [TestClass]
    public class UnitTest1
    {
  



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




        // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // AddAt METHODE TESTS // // // // //

        [TestMethod]
        public void AddAt_AddToStartList_IndexZeroIsAdded()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;

            // act
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.AddAt(1, 0);

            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddAt_AddToEndOfList_LastIndexIsAdded()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;

            // act
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.AddAt(1, 3);

            actual = testList[3];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddAt_AddToMiddleOfList_LastIndexIsAdded()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 3;
            int actual;

            // act
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.AddAt(1, 1);

            actual = testList[2];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddAt_AddToMiddleOfList_CountIncreases()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 4;
            int actual;

            // act
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.AddAt(1, 1);

            actual = testList.Count;

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
            public void Remove_RemoveValueFromEndOfList_BringsDownCOunt()
            {
                // arrange
                CustomList<int> testList = new CustomList<int>();
                int expected = 2;
                int actual;

                // act
                testList.Add(1);
                testList.Add(2);
                testList.Add(3);
                testList.Remove(3);
                actual = testList.Count;

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Remove_RemoveValueFromListCount2_ItemGoesToIndexZero()
            {
                // arrange
                CustomList<int> testList = new CustomList<int>();
                int expected = 2;
                int actual;

                // act
                testList.Add(1);
                testList.Add(2);

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


            // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // RemoveAt METHODE TESTS // // // // //


            [TestMethod]
            public void RemoveAt_RemoveFirstIndex_OneIndexBeomesZeroIndex()
            {
                // arrange
                CustomList<int> testList = new CustomList<int>();
                int expected = 2;
                int actual;

                // act
                testList.Add(1);
                testList.Add(2);
                testList.Add(3);
                testList.RemoveAt(0);
                actual = testList[0];

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void RemoveAt_RemoveIndexFromMiddleOfList_LastIndexGoesDown()
            {
                // arrange
                CustomList<int> testList = new CustomList<int>();
                int expected = 3;
                int actual;

                // act
                testList.Add(1);
                testList.Add(2);
                testList.Add(3);
                testList.RemoveAt(1);
                actual = testList[1];

                // assert
                Assert.AreEqual(expected, actual);
            }



            [TestMethod]
            public void RemoveAt_RemoveIndexFromList_CountDecrements()
            {
                // arrange
                CustomList<int> testList = new CustomList<int>();
                int expected = 2;
                int actual;

                // act
                testList.Add(1);
                testList.Add(2);
                testList.Add(3);
                testList.RemoveAt(0);
                actual = testList.Count;

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void RemoveAt_RemoveMultipleItemsfromList_CheckFirstIndex()
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
                testList.RemoveAt(0);
                testList.RemoveAt(0);
                testList.RemoveAt(0);


                actual = testList[0];

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void RemoveAt_RemoveMultipleItemsfromList_CheckCount()
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
                testList.RemoveAt(0);
                testList.RemoveAt(0);
                testList.RemoveAt(0);


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



            // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // ZIP METHODE TESTS // // // // //

            [TestMethod]
            public void Zip_ZipTwoEqualLengthLists_FirstIndexEqual()
            {
                // arrange
                CustomList<int> testList = new CustomList<int>();
                CustomList<int> testList2 = new CustomList<int>();
                testList.Add(1);
                testList.Add(3);
                testList.Add(5);
                testList2.Add(2);
                testList2.Add(4);
                testList2.Add(6);
                int expected = 1;
                int actual;

                // act
                CustomList<int> zipped = testList.Zip(testList2);

                actual = zipped[0];

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Zip_ZipTwoEqualLengthLists_LastIndexExpected()
            {
                // arrange
                CustomList<int> testList = new CustomList<int>();
                CustomList<int> testList2 = new CustomList<int>();
                testList.Add(1);
                testList.Add(3);
                testList.Add(5);
                testList2.Add(2);
                testList2.Add(4);
                testList2.Add(6);
                int expected = 6;
                int actual;

                // act
                CustomList<int> zipped = testList.Zip(testList2);

                actual = zipped[5];

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Zip_ZipTwoLists_CountBecomesDoubleShorterOfTwo()
            {
                // arrange
                CustomList<int> testList = new CustomList<int>();
                CustomList<int> testList2 = new CustomList<int>();

                testList.Add(1);
                testList.Add(3);
                testList.Add(5);

                testList2.Add(2);
                testList2.Add(4);


                int expected = 4;
                int actual;

                // act
                //testList.Zip(testList2);

                CustomList<int> zipped = testList.Zip(testList2);

                actual = zipped.Count;

                // assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Zip_ZipTwoListsFirstLower_CountBecomesShorterOfTwo()
            {
                // arrange
                CustomList<int> testList = new CustomList<int>();
                CustomList<int> testList2 = new CustomList<int>();

                testList.Add(1);



                testList2.Add(2);
                testList2.Add(4);
                testList2.Add(6);


                int expected = 2;
                int actual;

                // act
                CustomList<int> zipped = testList.Zip(testList2);

                actual = zipped.Count;

                // assert
                Assert.AreEqual(expected, actual);
            }


        // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // TO STRING  // // // // //

            [TestMethod]

            public void PlusOperatorOverLoad_DoesCombine2Lists_ReturnsCombinedList()
        {

            // arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testList3 = new CustomList<int>();

            testList.Add(1);
            testList.Add(2);
            testList.Add(3);

            testList2.Add(4);
            testList2.Add(5);
            testList2.Add(6);

            testList3.Add(1);
            testList3.Add(2);
            testList3.Add(3);
            testList3.Add(4);
            testList3.Add(5);
            testList3.Add(6);

            // act
            int expected = 6;
            int  actual = (testList + testList2)[5];
            // assert
            Assert.AreEqual(expected, actual);


        }


        [TestMethod]

        public void PlusOperatorOverLoad_DoesCombine2ListsCount_ReturnsCombinedCount()
        {

            // arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testList3 = new CustomList<int>();

            testList.Add(1);
            testList.Add(2);
            testList.Add(3);

            testList2.Add(4);
            testList2.Add(5);
            testList2.Add(6);

            testList3.Add(1);
            testList3.Add(2);
            testList3.Add(3);
            testList3.Add(4);
            testList3.Add(5);
            testList3.Add(6);

            // act
            int expected = 6;
            int actual = (testList + testList2).Count;
            // assert
            Assert.AreEqual(expected, actual);


        }


        // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // OPERATOR OVERLOAD // // // // //



        // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // INNUMERATORE  // // // // //


        [TestMethod]
        public void IEnumerable_DoesForEachWork_ReturnsSum()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            

            testList.Add(1);
            testList.Add(2);
            testList.Add(3);

            int sum = 0;
            int expected = 6;
            int actual;

            // act
            foreach(int item in testList )
            {
                sum += item;
            }

            actual = sum;

            // assert
            Assert.AreEqual(expected, actual);
        }






    }
}
