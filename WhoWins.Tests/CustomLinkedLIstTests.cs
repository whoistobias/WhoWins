using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhoWins.Api.CustomLinkedList;

namespace WhoWins.Tests
{
    [TestClass]
    public class CustomLinkedListTests
    {

        public CustomLinkedListTests()
        {
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        public void CustomLinkedList_AddingNItems_ReturnsNLengthList(int numberOfItems)
        {
            // Arrange
            var list = new CustomLinkedList<int>();

            // Act
            for (int i = 0; i < numberOfItems; i++)
            {
                list.Add(i);
            }

            // Assert
            Assert.AreEqual(numberOfItems, list.Length, "The linked list should contain the correct number of items");
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        public void CustomLinkedList_AddingNItemsViaConstructor_ReturnsNLengthList(int numberOfItems)
        {
            // Arrange
            int[] array = new int[numberOfItems];
            for (int i = 0; i < numberOfItems; i++)
            {
                array[i] = i;
            }

            // Act
            var list = new CustomLinkedList<int>(array);

            // Assert
            Assert.AreEqual(numberOfItems, list.Length, "The linked list should contain the correct number of items");
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        public void CustomLinkedList_AddingNItemsViaAdd_ReturnsNLengthList(int numberOfItems)
        {
            // Arrange
            int[] array = new int[numberOfItems];
            for (int i = 0; i < numberOfItems; i++)
            {
                array[i] = i;
            }
            var list = new CustomLinkedList<int>();

            // Act
            list.Add(array);

            // Assert
            Assert.AreEqual(numberOfItems, list.Length, "The linked list should contain the correct number of items");
        }

        [TestMethod]
        public void CustomLinkedList_CreatingDifferentTypedLists_WorksWithAnyType()
        {
            // Arrange
            var intList = new CustomLinkedList<int>();
            var stringList = new CustomLinkedList<string>();
            var listList = new CustomLinkedList<CustomLinkedList<int>>();

            // Act
            intList.Add(1, 2, 3);
            stringList.Add("One", "Two", "Three");
            listList.Add(new CustomLinkedList<int>(), new CustomLinkedList<int>(), new CustomLinkedList<int>());

            // Assert
            Assert.IsInstanceOfType(intList, typeof(CustomLinkedList<int>));
            Assert.IsInstanceOfType(stringList, typeof(CustomLinkedList<string>));
            Assert.IsInstanceOfType(listList, typeof(CustomLinkedList<CustomLinkedList<int>>));
        }

        [DataTestMethod]
        [DataRow(0, false)]
        [DataRow(1, true)]
        [DataRow(2, false)]
        [DataRow(3, true)]
        [DataRow(999, false)]
        public void CustomLinkedList_UsingContainsOnListOfInt_ReturnsCorrectBoolean(int numberToFind, bool shouldFindIt)
        {
            // Arrange
            var list = new CustomLinkedList<int>(1, 3, 5);
            // Act
            var found = list.Contains(numberToFind);
            // Assert
            Assert.AreEqual(shouldFindIt, found);
        }

        [DataTestMethod]
        [DataRow("test", false)]
        [DataRow("testing", true)]
        [DataRow("rekt", false)]
        [DataRow("Testing", false)]
        public void CustomLinkedList_UsingContainsOnListOfString_ReturnsCorrectBoolean(string stringToFind, bool shouldFindIt)
        {
            // Arrange
            var list = new CustomLinkedList<string>("testing", "this", "method");
            // Act
            var found = list.Contains(stringToFind);
            // Assert
            Assert.AreEqual(shouldFindIt, found);
        }

        [TestMethod]
        public void CustomLinkedList_UsingGet_ReturnsCorrectValue()
        {
            // Arrange
            var list = new CustomLinkedList<string>("testing", "this", "method");
            // Act
            var value0 = list.Get(0);
            var value1 = list.Get(1);
            var value2 = list.Get(2);
            // Assert
            Assert.AreEqual("testing", value0);
            Assert.AreEqual("this", value1);
            Assert.AreEqual("method", value2);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException), "CustomLinkedList should not allow out of range indexes.")]
        public void CustomLinkedList_UsingGetOutOfBounds_ThrowsException()
        {
            // Arrange
            var list = new CustomLinkedList<string>("testing", "this", "method");
            // Act
            var value0 = list.Get(4);
            // Assert
        }
    }
}