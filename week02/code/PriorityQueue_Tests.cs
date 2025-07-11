using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a priority queue and enqueue several items with different priorities.
    // Expected Result: The items should be dequeued in order of their priority.
    // Defect(s) Found: Expected high priority item to be dequeued first, but received medium priority item instead. The queue is not recognizing the highest priority correctly. The method `Dequeue` was not actually removing the items from the queue. The fix was to change the initial value of index to 1, and to remove the `- 1` on line 27, and added the line where the item is removed from the queue before returning its value.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("low priority", 1);
        priorityQueue.Enqueue("medium priority", 2);
        priorityQueue.Enqueue("high priority", 3);

        Assert.AreEqual("high priority", priorityQueue.Dequeue());
        Assert.AreEqual("medium priority", priorityQueue.Dequeue());
        Assert.AreEqual("low priority", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from an empty priority queue
    // Expected Result: An InvalidOperationException should be thrown
    // Defect(s) Found: None, the implementation is correct.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(priorityQueue.Dequeue);
    }

    [TestMethod]
    // Scenario: Create a priority queue and enqueue several items with the same priority.
    // Expected Result: The items should be dequeued in the order they were enqueued.
    // Defect(s) Found: Expected "item 1", but received "item 3" instead. The queue is removing the last item enqueued instead of the first one with the same priority. The fix was just removing the `=` in the condition of the `if` statement in the `Dequeue` method on line 29.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("item 1", 1);
        priorityQueue.Enqueue("item 2", 1);
        priorityQueue.Enqueue("item 3", 1);

        Assert.AreEqual("item 1", priorityQueue.Dequeue());
        Assert.AreEqual("item 2", priorityQueue.Dequeue());
        Assert.AreEqual("item 3", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: Create a priority queue and enqueue two items with the same priority and one with a higher priority.
    // Expected Result: The item with the higher priority should be dequeued first.
    // Defect(s) Found: Expected "item 1", but received "item 2" instead. After the queue removes the highest priority item, it should remove the first item with the same priority, not the last one.  The fix was just removing the `=` in the condition of the `if` statement in the `Dequeue` method on line 29.
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("item 1", 1);
        priorityQueue.Enqueue("item 2", 1);
        priorityQueue.Enqueue("item 3", 2);

        Assert.AreEqual("item 3", priorityQueue.Dequeue());
        Assert.AreEqual("item 1", priorityQueue.Dequeue());
        Assert.AreEqual("item 2", priorityQueue.Dequeue());
    }
}