﻿namespace BinaryTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Binary<int> binary = new Binary<int>(56);
            binary.add(30);
            binary.add(70);
            binary.add(22);
            binary.add(40);
            binary.add(60);
            binary.add(95);
            binary.add(11);
            binary.add(03);
            binary.add(16);
            binary.add(65);
            binary.add(63);
            binary.add(67);
            binary.Display();
            binary.Search(63, binary);
            binary.GetSize();



        }
    }
}