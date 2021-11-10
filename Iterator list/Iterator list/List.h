#ifndef LIST_H
#define LIST_H

class List{

	struct Node{
		int x;                             
		Node *Next, *Prev;                 
	};

    Node *Head, *Tail;   

	public:
		List();
		~List();
		void Show();    
		void Add(int x);                   
 };

#endif