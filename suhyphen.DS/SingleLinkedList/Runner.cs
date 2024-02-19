namespace suhyphen.DS.SingleLinkedList
{
    internal class Runner
    {
        public static void Run()
        {
            SingleLinkedList singleLinkedList = new SingleLinkedList();
            SingleLinkedListHelper singleLinkedListHelper = new SingleLinkedListHelper();
            singleLinkedListHelper.InsertFront(singleLinkedList, 10);
            singleLinkedListHelper.InsertFront(singleLinkedList, 11);
            singleLinkedListHelper.InsertFront(singleLinkedList, 12);
            singleLinkedListHelper.InsertFront(singleLinkedList, 13);
            singleLinkedListHelper.InsertFront(singleLinkedList, 14);

            // This should output: 14 13 12 11 10
            singleLinkedListHelper.Traverse(singleLinkedList);

            singleLinkedListHelper.InsertLast(singleLinkedList, 50);
            singleLinkedListHelper.InsertLast(singleLinkedList, 60);
            singleLinkedListHelper.InsertLast(singleLinkedList, 70);
            singleLinkedListHelper.InsertLast(singleLinkedList, 80);

            // This should output: 14 13 12 11 10 50 60 70 80
            singleLinkedListHelper.Traverse(singleLinkedList);

            singleLinkedListHelper.DeleteNodeByKey(singleLinkedList, 14);

            // This should output: 13 12 11 10 50 60 70 80
            singleLinkedListHelper.Traverse(singleLinkedList);

            singleLinkedListHelper.DeleteNodeByKey(singleLinkedList, 60);
            singleLinkedListHelper.DeleteNodeByKey(singleLinkedList, 12);

            // This should output: 13 11 10 50 70 80
            singleLinkedListHelper.Traverse(singleLinkedList);
        }
    }
}
