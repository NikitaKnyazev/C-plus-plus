#ifndef LIST3_H
#define LIST3_H
#include <iterator> 
#include <cstddef> 
#include <iostream>

class List3 {

	struct Node {
		int x;
		Node* Next, * Prev;
	};	

	public:
		struct Iterator { 
			using iterator_category = std::bidirectional_iterator_tag;
			using difference_type = std::ptrdiff_t;
			using value_type = int;
			using pointer = Node*;  
			using reference = Node&;

			Iterator(pointer ptr) : m_ptr(ptr) {}

			int operator*() const { 
				return m_ptr->x; 
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

			private:
				pointer m_ptr;
		};

		Node* Head, * Tail;

		List3();
		~List3();
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
};

#endif
