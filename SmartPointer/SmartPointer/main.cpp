#include <iostream>

using namespace std;

template<class T>
class SmartPointer{
	T* sp;
	public:	
		SmartPointer(T* temp=nullptr):sp(temp){}	
		~SmartPointer(){delete sp;}
		T& operator*() const {return *sp;}
		T* operator->() const {return sp;}
};
 

class List{
	struct Node{
		int x;                             
		Node *Next, *Prev;                 
	};

    Node *Head, *Tail;   

	public:
		List():Head(NULL), Tail(NULL){cout<<"List created"<<endl;};    
		~List(){
			while(Head){
			Tail = Head->Next;            
			delete Head;                  
			Head = Tail;                  
			}
			cout<<"List destroyed"<<endl;
		};    

		void Show(){
			Node *temp = Head;                       
			while (temp != NULL){
				cout<<temp->x<<" ";       
				temp = temp->Next;            
			}
			cout<<"\n";
		};     

		void Add(int x){
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
 };

void foo(){
	SmartPointer<List> lst(new List);  
	lst->Add(1); 
	lst->Add(2);
	lst->Add(5);
	lst->Add(7);
	lst->Add(10);
	lst->Show(); 
}

int main(){
	system("CLS");
	
	foo();

	system("pause");
	return 0;
}