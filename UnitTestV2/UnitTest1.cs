using System;
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
        public void Remove_ListSize2Remove1_LastIndexGoesDown()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>() { 1, 2 };
            int expected = 2;
            int actual;

            // act
            testList.Remove(1);
           
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_ListSize2Remove1_CountGoesDown()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>() { 1, 2 };
            int expected = 1;
            int actual;

            // act
            testList.Remove(1);

            actual = testList.Count;

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

        [TestMethod]
        public void Remove_RemoveMultipleItemsfromListDownTo1_CheckCount()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>() { 3, 3, 3, 3, 3 };
            int expected = 1;
            int actual;

            // act
            testList.Remove(3);
            testList.Remove(3);
            testList.Remove(3);
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
        // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // RemoveAll METHODE TESTS // // // // //


        [TestMethod]
        public void RemoveAll_RemoveAllOCcurances_noMoreFours()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>() { 4, 4, 0, 0, 4, 4, 0, 0 };
            CustomList<int> expected = new CustomList<int>() { 0, 0, 0, 0 };


            // act
            testList.RemoveAll(4);
            CustomList<int> actual = testList;
            

            // assert
            for ( int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
            
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


        [TestMethod]
        public void GrowArray_ExceedLaterCapacity_CapacityDoubles()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>() {1,2,3,4,5,6,7,8};
            int expected = 16;
            int actual;

            // act
            testList.Add(9);

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

        [TestMethod]
        public void Zip_Zip2InitializedLists_ReturnZippedList()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>() { 0, 0, 0, 0, 0 };
            CustomList<int> testList2 = new CustomList<int>() { 1, 1, 1, 1, 1 };
 
            CustomList<int> expected = new CustomList<int> { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 };

            // act
            CustomList<int> actual = testList.Zip(testList2);

    
            // assert
            for ( int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
           
        }


        // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // TO STRING  // // // // //


        [TestMethod]

        public void StringInOverRide_GetStringReturnOnInt_ReturnsStringOfInts()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();         

            testList.Add(1);
            testList.Add(2);
            testList.Add(3);

            // act
            string expected = "[1, 2, 3]";
            string actual = testList.ToString();
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void StringInOverRide_GetStringReturnOnString_ReturnsStringsInline()
        {
            // arrange
            CustomList<string> testList = new CustomList<string>();

            testList.Add("one");
            testList.Add("two");
            testList.Add("three");

            // act
            string expected = "[one, two, three]";
            string actual = testList.ToString();
            // assert
            Assert.AreEqual(expected, actual);
        }


        // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // OPERATOR OVERLOAD // // // // //

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

        public void PlusOperatorOverLoad_DoesCombineMultiple_ReturnsCombinedList()
        {

            // arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testList3 = new CustomList<int>();
            CustomList<int> expected = new CustomList<int>();

            testList.Add(1);
            testList.Add(2);
            testList.Add(3);

            testList2.Add(4);
            testList3.Add(5);
            testList3.Add(6);

            expected.Add(1);
            expected.Add(2);
            expected.Add(3);
            expected.Add(4);
            expected.Add(5);
            expected.Add(6);

            // act
           
            CustomList<int> actual = (testList + testList2 + testList3);
            // assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);

            }
           

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

        [TestMethod]

        public void MinusOperatorOverLoad_DoesSubtract_ReturnsShortenedList()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testList3 = new CustomList<int>();

            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);

            testList2.Add(4);
            testList2.Add(5);
           
            // act
            int expected = 6;
            int actual = (testList - testList2)[3];
            // assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]

        public void MinusOperatorOverLoad_DoesSubtract_CheckWholeList()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };
            CustomList<int> testList2 = new CustomList<int>(){1, 2, 3};
            CustomList<int> expected = new CustomList<int>() { 4, 5, 6 };

            int expectedCount = 3;
            
            // act
            
            CustomList<int> actual = (testList - testList2);
            int actualCount = actual.Count;
            // assert
            for ( int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }

            Assert.AreEqual(expectedCount, actualCount);
        }

      


        [TestMethod]
        public void MinusOperatorOverLoad_DoesSubtract_ReturnsShortenedCount()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            

            testList.Add(1);
            testList.Add(2);
            testList.Add(4);
            testList.Add(4);
            testList.Add(4);
            testList.Add(6);

            testList2.Add(4);
            testList2.Add(4);

            // act
            int expected = 4;
            int actual = (testList - testList2).Count;
            // assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]

        public void MinusOperatorOverLoad_SubstractALl_ReturnsCountZero()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testList3 = new CustomList<int>();

            testList.Add(1);
            testList.Add(2);
            testList.Add(4);
            testList.Add(4);
            testList.Add(4);
            testList.Add(6);

            testList2.Add(4);
            testList2.Add(4);

            // act
            int expected = 0;
            int actual = (testList2 - testList).Count;
            // assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]

        public void MinusOperatorOverLoad_DoesSubstractMultiple_ReturnsCombinedList()
        {

            // arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testList3 = new CustomList<int>();
            CustomList<int> expected = new CustomList<int>();

            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);

            testList2.Add(4);

            testList3.Add(5);
            testList3.Add(6);

            expected.Add(1);
            expected.Add(2);
            expected.Add(3);
       

            // act

            CustomList<int> actual = (testList - testList2 - testList3);
            // assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);

            }


        }





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



        // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // HELPERS  // // // // //

        // CONTAINS


        [TestMethod]

        public void Contains_DoesReturnTrueIfYes_ReturnsTrue()
        {

            // arrange
            CustomList<int> testList = new CustomList<int>();
           

            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);

            // act
            bool expected = true;
            bool actual = testList.Contains(4);
            // assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]

        public void Contains_DoesReturnFalseIfNo_ReturnsFalse()
        {

            // arrange
            CustomList<int> testList = new CustomList<int>();


            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);

            // act
            bool expected = false;
            bool actual = testList.Contains(7);
            // assert
            Assert.AreEqual(expected, actual);


        }

        // INDEX OF


        [TestMethod]

        public void IndexOf_ReturnProperIndex_ReturnsFirstIndex()
        {

            // arrange
            CustomList<int> testList = new CustomList<int>();


            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(4);

            // act
            int expected = 3;
            int actual = testList.IndexOf(4);
            // assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]

        public void IndexOf_NotFound_ReturnNegOne()
        {

            // arrange
            CustomList<int> testList = new CustomList<int>();


            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);

            // act
            int expected = -1;
            int actual = testList.IndexOf(7);
            // assert
            Assert.AreEqual(expected, actual);


        }



        // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // SORT  // // // // //


        [TestMethod]
        public void Sort_CheckStartOfList_ReturnsIndex0()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>() { 3, 2, 1 };

            int expected = 1;

            testList.Sort<int>(0, testList.Count);
            int actual = testList[0];
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sort_CheckEndOfList_ReturnsIndexLast()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>() { 3, 2, 1 };

            int expected = 3;
            testList.Sort<int>(0, testList.Count);
            int actual = testList[testList.Count-1];
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sort_CheckList_ComparesAllValues()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>() { 3, 2, 1, 5, 4 };

            CustomList<int> expected = new CustomList<int>() { 1, 2, 3, 4, 5 };

            testList.Sort<int>(0, testList.Count);
            CustomList<int> actual = testList;
            // assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }




        [TestMethod]
        public void SortLargestFirst_CheckEnd_ReturnsEndOfList()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>() { 4, 7, 1, 8, 3, 2, 1 };

            int expected = 8;
            int expected2 = 1;

            CustomList<int> TEST = testList.SortLargestFirst(testList, testList.Count, 0);
            CustomList<int> TEST2 = testList.SortSmallest(TEST, TEST.Count, 0);

            int actual2 = TEST2[0];
            int actual = TEST[testList.Count - 1];
            // assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        public void SortLargestFirst_CheckFull_ReturnsWhole()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>() { 4, 7, 1, 8, 3, 2, 1 };
            CustomList<int> expected = new CustomList<int>() { 1, 1, 2, 3, 4, 7, 8 };

      
            CustomList<int> actual = testList.SortCombined(testList, testList.Count, 0);
         
            // assert
            for ( int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
            
        }


        [TestMethod]
        public void SortCombined_CheckFull_ReturnsWhole()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>() { 10, 9, 8, 7, 6, 5, 4 };
            CustomList<int> expected = new CustomList<int>() { 4, 5, 6, 7, 8, 9, 10 };


            CustomList<int> actual = testList.SortCombined(testList, testList.Count, 0);

            // assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }

        }






    }
}
