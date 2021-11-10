#include "List.h"
#include <iostream>

List::List():Head(NULL), Tail(NULL){}; 

List::~List(){
			while(Head){
			Tail = Head->Next;            
			delete Head;                  
			Head = Tail;                  
			}			
		};  

void List::Show(){
			Node *temp = Head;                       
			while (temp != NULL){
				std::cout<<temp->x<<" ";       
				temp = temp->Next;            
			}
			std::cout<<"\n";
		};  

void List::Add(int x){
			Node *temp = new Node;               
			temp->Next = NULL;                   
			temp->x = x;                         
			if (Head != NULL){
				temp->Prev = Tail;               
				Tail->Next = temp;              
				Tail = temp;                     
			}
			else{
				temp->Prev = NULL;               
				Head = Tail = temp;              
			}
		};   