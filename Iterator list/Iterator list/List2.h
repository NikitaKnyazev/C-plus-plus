#ifndef LIST2_H
#define LIST2_H
#include "OwnIterator.h"
#include <memory>

class List2{

	struct Node{
		int x;                             
		Node *Next, *Prev;                 
	};

    Node *Head, *Tail;   

	public:
		//List2();
		~List2();
		void Show();    
		void Add(int x);  
		typedef OwnIterator<int> iterator;
		typedef OwnIterator<const int> const_iterator;
		List2(std::initializer_list<int> values);
		iterator begin();
		iterator end();
		const_iterator begin() const;
		const_iterator end() const;
			
	private:
		const size_t size;
		std::unique_ptr<int[]> data;
 };

#endif