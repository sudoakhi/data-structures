namespace suhyphen.DS.SinglyLinkedList
{
    internal class Runner
    {
        public static void Run()
        {
            SingleLinkedList singleLinkedList = new SingleLinkedList();
            singleLinkedList.InsertFront(singleLinkedList, 10);
            singleLinkedList.InsertFront(singleLinkedList, 11);
            singleLinkedList.InsertFront(singleLinkedList, 12);
            singleLinkedList.InsertFront(singleLinkedList, 13);
            singleLinkedList.InsertFront(singleLinkedList, 14);

            // This should output: 14 13 12 11 10
            singleLinkedList.Traverse(singleLinkedList);

            singleLinkedList.InsertLast(singleLinkedList, 50);
            singleLinkedList.InsertLast(singleLinkedList, 60);
            singleLinkedList.InsertLast(singleLinkedList, 70);
            singleLinkedList.InsertLast(singleLinkedList, 80);

            // This should output: 14 13 12 11 10 50 60 70 80
            singleLinkedList.Traverse(singleLinkedList);

            singleLinkedList.DeleteNodeByKey(singleLinkedList, 14);

            // This should output: 13 12 11 10 50 60 70 80
            singleLinkedList.Traverse(singleLinkedList);

            singleLinkedList.DeleteNodeByKey(singleLinkedList, 60);
            singleLinkedList.DeleteNodeByKey(singleLinkedList, 12);

            // This should output: 13 11 10 50 70 80
            singleLinkedList.Traverse(singleLinkedList);
        }
    }
}
