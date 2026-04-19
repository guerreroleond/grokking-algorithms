using GrokkingAlgorithms.DataStructures;

namespace GrokkingAlgorithms._02SelectionSort;

public class OrderQueue
{
    SinglyLinkedList? _orders = null;
    SinglyLinkedList? _lastOrder = null;

    public void Add(string item)
    {
        if (_orders == null)
        {
            _orders = new SinglyLinkedList
            {
                Data = item
            };
            _lastOrder = _orders;
        }
        else
        {
            var newOrder = new SinglyLinkedList
            {
                Data = item
            };
            // Place new order at the end.
            _lastOrder.Next = newOrder;
            _lastOrder = newOrder;
        }
    }

    public string Take()
    {
        if (_orders == null) return string.Empty;

        var order = _orders.Data;
        _orders = _orders.Next;

        return order;
    }
}
