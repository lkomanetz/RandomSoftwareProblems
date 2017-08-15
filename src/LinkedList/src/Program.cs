using System;
using System.Collections.Generic;

namespace src {

    class Program {

        static void Main(string[] args) {
            try {
                Program p = new Program();
                int size = p.GetListSize();
                var list = p.BuildList(size);

                p.Dump(list);

                var node = p.GetMiddleNode(list);
                Console.WriteLine($"Middle node value is '{node.Value}'");
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        internal LinkedListNode<int> GetMiddleNode(LinkedList<int> list) {
            LinkedListNode<int> node = list.First;
            int iteration = 1;
            while (iteration != list.Count) {
                if (iteration % 2 == 0) {
                    node = node.Next;
                }

                iteration++;
            }

            return node;
        }

        internal void Dump(LinkedList<int> list) {
            foreach (var value in list) {
                Console.WriteLine($"Node Value: '{value}'");
            }
        }

        internal LinkedList<int> BuildList(int size) {
            LinkedList<int> list = new LinkedList<int>();

            for (int i = 0; i < size; ++i) {
                list.AddLast(i);
            }

            return list;
        }

        internal int GetListSize() {
            Console.Write("Enter Linked List Size:  ");
            return Int32.Parse(Console.ReadLine());
        }

    }

}