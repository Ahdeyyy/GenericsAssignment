using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericSort;

namespace GenericSortTests;

[TestClass]
public class GenericSortTest
{

    /// <summary>
    /// Tests the Sort.QSort method with an empty array.
    /// This test checks if the method can handle an empty array without throwing exceptions
    /// and returns an empty array as expected. 
    /// </summary>

    [TestMethod]
    public void TestEmptyArraySorting()
    {
        int[] emptyArray = [];
        int[] expected = [];
        int[] sortedArray = Sort.QSort(emptyArray);

        Assert.AreEqual(expected.Length, sortedArray.Length, "Expected empty array length doesn't match sorted empty array length");
        Assert.AreEqual(expected.ToString(), sortedArray.ToString(), "Expected empty array doesn't match sorted empty array");
    }


    /// <summary>
    /// Tests the Sort.QSort method with a string array.
    /// This test checks if the method can sort an array of strings correctly.
    /// </summary>

    [TestMethod]
    public void TestStringSorting()
    {

        string[] strings = ["banana", "cucumber", "apple"];
        string[] expected = ["apple", "banana", "cucumber"];
        string[] sortedStrings = Sort.QSort(strings);

        Assert.AreEqual(expected.Length, sortedStrings.Length, "Expected string array length doesn't match sorted string array length");
        Assert.AreEqual(expected.ToString(), sortedStrings.ToString(), "Expected string array doesn't match sorted string array");

    }

    /// <summary>
    /// Tests the Sort.QSort method with a string array containing duplicate strings.
    ///  This test checks if the method can handle duplicate strings correctly and sorts them in order.
    /// </summary>

    [TestMethod]
    public void TestDuplicateStringSorting()
    {

        string[] strings = ["apple", "banana", "cucumber", "apple"];
        string[] expected = ["apple", "apple", "banana", "cucumber"];
        string[] sortedStrings = Sort.QSort(strings);

        Assert.AreEqual(expected.Length, sortedStrings.Length, "Expected string array length doesn't match sorted string array length");
        Assert.AreEqual(expected.ToString(), sortedStrings.ToString(), "Expected string array doesn't match sorted string array");

    }

    /// <summary>
    /// Tests the Sort.QSort method with an integer array.
    /// This test checks if the method can sort an array of integers correctly.
    /// </summary>

    [TestMethod]
    public void TestIntegerSorting()
    {
        int[] ints = [2, 1, 3];
        int[] expected = [1, 2, 3];
        int[] sortedInts = Sort.QSort(ints);

        Assert.AreEqual(expected.Length, sortedInts.Length, "Expected int array length doesn't match sorted stirng array length");
        Assert.AreEqual(expected.ToString(), ints.ToString(), "Expected int array doesn't match sorted int array");
    }

    /// <summary>
    /// Tests the Sort.QSort method with a char array.
    /// This test checks if the method can sort an array of characters correctly.
    /// </summary>

    [TestMethod]
    public void TestCharSorting()
    {
        char[] chars = ['b', 'a', 'c'];
        char[] expected = ['a', 'b', 'c'];
        char[] sortedChars = Sort.QSort(chars);

        Assert.AreEqual(expected.Length, sortedChars.Length, "Expected char array length doesn't match sorted char array length");
        Assert.AreEqual(expected.ToString(), sortedChars.ToString(), "Expected char array doesn't match sorted char array");
    }
}
