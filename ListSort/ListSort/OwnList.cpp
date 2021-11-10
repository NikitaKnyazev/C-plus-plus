#include "OwnList.h"
#include <iostream>

OwnList::OwnList():Head(NULL), Tail(NULL), count(0) {};

OwnList::~OwnList() {
	while (Head) {
		Tail = Head->Next;
		delete Head;
		Head = Tail;
	}
};

void OwnList::Show() {
	Node* temp = Head;
	while (temp != NULL) {
		std::cout << temp->num << ": " << temp->x << "\t";
		temp = temp->Next;
	}
	std::cout << "\n";
};

void OwnList::Add(int x) {
	Node* temp = new Node;
	++count;
	temp->Next = NULL;
	temp->x = x;
	if (Head != NULL) {
		temp->Prev = Tail;
		temp->num = Tail->num + 1;
		Tail->Next = temp;
		Tail = temp;
	}
	else {
		temp->Prev = NULL;
		Head = Tail = temp;
		temp->num = 1;
	}
};


void OwnList::Insert(Iterator it, int x) {
	++count;
	Node* temp = Head;
	int tt;

	while (temp != it)
		temp = temp->Next;

	while (it != NULL) {
		tt = temp->x;
		temp->x = x;
		x = tt;
		++it;
		temp = temp->Next;
	}
	Add(x);
}


void OwnList::Erase(Iterator it) {
	--count;
	Node* temp = Head;

	while (temp != it)
		temp = temp->Next;

	while (it != Tail) {
		temp->x = temp->Next->x;
		temp = temp->Next;
		++it;
	}

	Tail = temp->Prev;
	temp->Prev->Next = NULL;
	temp->Prev = NULL;
	temp->Next = NULL;
}


void OwnList::sort(){
	auto it = end();
	int t;
	for (int k = 1; k < count - 1; ++k) {
		Node* temp = Head;
		while (temp != it) {			
			if (temp->x > temp->Next->x) {
				t = temp->x;
				temp->x = temp->Next->x;
				temp->Next->x = t;
			}
			temp = temp->Next;
		}
		--it;
	}
}


void OwnList::LinearSearch(int x) {
	auto it = begin();
	for (it; it != NULL; ++it)
		if (x == *it) {
			std::cout << "Element " << x << " is found! Its number is " << it.num() << std::endl;
			return;
		}
	std::cout << "List doesn't have element " << x << "\n";	
}