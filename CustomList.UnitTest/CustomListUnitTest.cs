using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomList.UnitTest
{
    [TestClass]
    public class CustomListUnitTest
    {

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
            actual = testList.count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddItemsToList_BeyondCapacityCount()
        {
            CustomList<int> testList = new CustomList<int>();
            int expected = 5;
            int actual;

            testList.Add(6);
            testList.Add(5);
            testList.Add(4);
            testList.Add(3);
            testList.Add(2);
            actual = testList.count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddItemsToList_BeyondCapacityLastIndex()
        {
            CustomList<int> testList = new CustomList<int>();
            int expected = 2;
            int actual;

            testList.Add(6);
            testList.Add(5);
            testList.Add(4);
            testList.Add(3);
            testList.Add(2);
            actual = testList[4];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveOneItemFromList_CountDecrease()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 3;
            int actual;

            // act
            testList.Add(6);
            testList.Add(5);
            testList.Add(4);
            testList.Add(3);
            testList.Remove(4);
            actual = testList.count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemoveIndex1FromList_ItemsShift()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 12;
            int actual;

            // act
            testList.Add(14);
            testList.Add(13);
            testList.Add(12);
            testList.Remove(13);
            actual = testList[1];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_Remove1StringFromList_Index1Change()
        {
            // arrange
            CustomList<string> testList = new CustomList<string>();
            string expected = "Camp";
            string actual;

            // act
            testList.Add("dev");
            testList.Add("Code");
            testList.Add("Camp");
            testList.Remove("Code");
            actual = testList[1];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_StringItems_ToString()
        {
            // arrange
            CustomList<string> testList = new CustomList<string>();
            string expected = "ball";
            string actual;

            // act
            testList.Add("b");
            testList.Add("a");
            testList.Add("l");
            testList.Add("l");
            actual = testList.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_IntItems_ToString()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            string expected = "1234";
            string actual;

            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            actual = testList.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}