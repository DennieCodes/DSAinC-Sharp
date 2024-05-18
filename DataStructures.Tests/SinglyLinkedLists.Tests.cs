using DataStructuresAndAlgorithms.DataStructures;

namespace DataStructures.Tests;

[TestClass]
public class SinglyLinkedListsTests
{
    [TestMethod]
    public void Append_IncrementsCount()
    {
        // Arrange
        var sll = new SinglyLinkedList();

        // Act
        sll.Append("Test Data");

        // Assert
        Assert.AreEqual(1, sll.count);
    }
}