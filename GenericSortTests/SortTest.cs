using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericSort;

namespace GenericSortTests;

[TestClass]
public class GenericSortTest
{

    [TestMethod]
    public void TestEmptyArraySorting()
    {
        int[] emptyArray = [];
        int[] expected = [];
        int[] sortedArray = Sort.QSort(emptyArray);

        Assert.AreEqual(expected.Length, sortedArray.Length, "Expected empty array length doesn't match sorted empty array length");
        Assert.AreEqual(expected.ToString(), sortedArray.ToString(), "Expected empty array doesn't match sorted empty array");
    }


    [TestMethod]
    public void TestStringSorting()
    {

        string[] strings = ["b", "c", "a"];
        string[] expected = ["a", "b", "c"];
        string[] sortedStrings = Sort.QSort(strings);

        Assert.AreEqual(expected.Length, sortedStrings.Length, "Expected string array length doesn't match sorted string array length");
        Assert.AreEqual(expected.ToString(), sortedStrings.ToString(), "Expected string array doesn't match sorted string array");

    }

    [TestMethod]
    public void TestDuplicateStringSorting()
    {

        string[] strings = ["a", "b", "c", "a"];
        string[] expected = ["a", "a", "b", "c"];
        string[] sortedStrings = Sort.QSort(strings);

        Assert.AreEqual(expected.Length, sortedStrings.Length, "Expected string array length doesn't match sorted string array length");
        Assert.AreEqual(expected.ToString(), sortedStrings.ToString(), "Expected string array doesn't match sorted string array");

    }

    [TestMethod]
    public void TestIntegerSorting()
    {
        int[] ints = [2, 1, 3];
        int[] expected = [1, 2, 3];
        int[] sortedInts = Sort.QSort(ints);

        Assert.AreEqual(expected.Length, sortedInts.Length, "Expected int array length doesn't match sorted stirng array length");
        Assert.AreEqual(expected.ToString(), ints.ToString(), "Expected int array doesn't match sorted int array");
    }
}
