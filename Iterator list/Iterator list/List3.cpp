#include "List3.h"
#include <iostream>

List3::List3() :Head(NULL), Tail(NULL) {};

List3::~List3() {
	while (Head) {
		Tail = Head->Next;
		delete Head;
		Head = Tail;
	}
};

void List3::Show() {
	Node* temp = Head;
	while (temp != NULL) {
		std::cout << temp->x << " ";
		temp = temp->Next;
	}
	std::cout << "\n";
};

void List3::Add(int x) {
	Node* temp = new Node;
	temp->Next = NULL;
	temp->x = x;
	if (Head != NULL) {
		temp->Prev = Tail;
		Tail->Next = temp;
		Tail = temp;
	}
	else {
		temp->Prev = NULL;
		Head = Tail = temp;
	}
};


void List3::Insert(Iterator it, int x) {
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
	//tt = temp->x;
	//temp->x = x;
	//x = tt;
	Add(x);
}


void List3::Erase(Iterator it) {
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
