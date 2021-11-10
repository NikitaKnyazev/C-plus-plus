#ifndef OWNLIST_H
#define OWNLIST_H

#include <iterator> 
#include <cstddef> 
#include <iostream>

class OwnList {

	struct Node {
		int x, num;
		Node* Next, * Prev;
	};

public:
	struct Iterator {
		using iterator_category = std::bidirectional_iterator_tag;
		using difference_type = std::ptrdiff_t;
		using value_type = int;
		using pointer = Node*;
		using reference = Node&;

		Iterator(pointer ptr) : m_ptr(ptr){}

		int operator*() const {
			return m_ptr->x;
		}

		int num() {
			return m_ptr->num;
		}

		// Prefix inc
		Iterator& operator++() {
			m_ptr = m_ptr->Next;
			return *this;
		}

		// Postfix inc
		Iterator operator++(int) {
			Iterator tmp = *this;
			++* this;
			return tmp;
		}

		// Prefix dec
		Iterator& operator--() {
			m_ptr = m_ptr->Prev;
			return *this;
		}

		// Postfix dec
		Iterator operator--(int) {
			Iterator tmp = *this;
			--* this;
			return tmp;
		}

		friend bool operator== (const Iterator& a, const Iterator& b) {
			return a.m_ptr == b.m_ptr;
		};
		friend bool operator!= (const Iterator& a, const Iterator& b) {
			return a.m_ptr != b.m_ptr;
		};
		friend bool operator< (const Iterator& a, const Iterator& b) {
			return a.m_ptr->num < b.m_ptr->num;
		};
		friend bool operator<= (const Iterator& a, const Iterator& b) {
			return a.m_ptr->num <= b.m_ptr->num;
		};
		friend bool operator> (const Iterator& a, const Iterator& b) {
			return a.m_ptr->num > b.m_ptr->num;
		};
		friend bool operator>= (const Iterator& a, const Iterator& b) {
			return a.m_ptr->num >= b.m_ptr->num;
		};

	private:
		pointer m_ptr;
	};

	Node* Head, * Tail;
	int count;

	OwnList();
	~OwnList();
	void Show();
	void Add(int x);

	Iterator begin() {
		return Head;
	};

	Iterator end() {
		return Tail;
	};

	void Insert(Iterator it, int x);
	void Erase(Iterator it);
	void sort();
	void LinearSearch(int x);
};

#endif
