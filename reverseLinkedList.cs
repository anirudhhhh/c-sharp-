using System;

class node{
    public int val;
    public node next;
}

class mainMethods{

    static string inputElement;
    static bool takingInputs = true;
    static node Node = new node();

    static node reverse(node n){
        node curr = n, prev = null, next = null;
        while(curr != null){
            next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }
        return prev;
    }

    static void printNode(node n){
        while(n != null){
            Console.WriteLine(Convert.ToString(n.val));
            n = n.next;
        }
    }

    static void takeInputs(node n){
        while(takingInputs){
            inputElement = Console.ReadLine();
            try{
                n.val = int.Parse(inputElement);
                n.next = new node();
                n = n.next;
            }
            catch{
                takingInputs = false;
            }
        }
    }

    public static void Main(string[] args){
        Console.WriteLine("keep writing integers and stop wherever you like by inputting anything else\n");
        takeInputs(Node);
        Node = reverse(Node);
        Node = Node.next;
        printNode(Node);
    }
}