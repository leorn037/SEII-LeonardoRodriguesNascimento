using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsDataStructuresCourse2022.BinarySearchTree;

namespace AlgorithmsDataStructuresCourse2022.BinarySearchTree
{
    public class BinarySearchTree
    {
        public TreeNode Root { get; set; } = null;
        public void Insert(int key, string value){

            Root = InsertItem(Root,key,value);
        }

         public TreeNode InsertItem(TreeNode node, int key, string value)
         {

            TreeNode newNode = new TreeNode(key,value);

            if(node==null){
                node=newNode;
                return node;
            }
            if(key<node.Key)
            {
                node.LeftChild = InsertItem(node.LeftChild, key, value);

            }
            else
            {
                node.RightChild = InsertItem(node.RightChild, key, value);

            }
        }
        
        
    


        public string Find (int key)
        {
            TreeNode node = Find(Root, key);
            return node == null ? null: node.Value;

        }
        private TreeNode? Find(TreeNode node, int key)
        {
            if(node==null || node.key ==key)
            {
                return node;
            }
            else if (key<node.Key)
            {
                return Find(node.LeftChild, key);
            }
            else if (key>node.Key)
            {
                return Find(node.RightChild, key);
            }
            return null;

        }



    }
}

using AlgorithnsDataStructuresCourse2022.BinarySearchTree;

BinarySearchTree bst = new BinarySearchTree();

bst.Insert(7, "Squirtle");
bst.Insert(23, "Ekans");
bst.Insert(151, "Hew");
bst.Insert(4, "Charmander");
bst.Insert(l, "Bulbasaur");

Console.WriteLine(bst.Find(151));