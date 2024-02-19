namespace DataStructures.SingleLinkedList
{
    internal static class Runner
    {
        public static void Run()
        {
            var singleLinkedList = new SingleLinkedList();
			SingleLinkedListHelper.InsertFront ( singleLinkedList, 10);
			SingleLinkedListHelper.InsertFront ( singleLinkedList, 11);
			SingleLinkedListHelper.InsertFront ( singleLinkedList, 12);
			SingleLinkedListHelper.InsertFront ( singleLinkedList, 13);
			SingleLinkedListHelper.InsertFront ( singleLinkedList, 14);

			// This should output: 14 13 12 11 10
			SingleLinkedListHelper.Traverse ( singleLinkedList);

			SingleLinkedListHelper.InsertLast ( singleLinkedList, 50);
			SingleLinkedListHelper.InsertLast ( singleLinkedList, 60);
			SingleLinkedListHelper.InsertLast ( singleLinkedList, 70);
			SingleLinkedListHelper.InsertLast ( singleLinkedList, 80);

			// This should output: 14 13 12 11 10 50 60 70 80
			SingleLinkedListHelper.Traverse ( singleLinkedList);

			SingleLinkedListHelper.DeleteNodeByKey ( singleLinkedList, 14);

			// This should output: 13 12 11 10 50 60 70 80
			SingleLinkedListHelper.Traverse ( singleLinkedList);

			SingleLinkedListHelper.DeleteNodeByKey ( singleLinkedList, 60);
			SingleLinkedListHelper.DeleteNodeByKey ( singleLinkedList, 12);

			// This should output: 13 11 10 50 70 80
			SingleLinkedListHelper.Traverse ( singleLinkedList);
        }
    }
}
