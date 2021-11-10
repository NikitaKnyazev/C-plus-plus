#include <iostream>

using namespace std;

template <typename T>
class List{

	struct Node{
		T x;                             
		Node *Next, *Prev;                 
	};

     Node *Head, *Tail;   

 public:
     List():Head(NULL), Tail(NULL){};    
     ~List(){
		 while(Head){
         Tail = Head->Next;            
         delete Head;                  
         Head = Tail;                  
		}
	 };    

     void Show(){
		Node *temp = Head;                       
		while (temp != NULL){
			cout<<temp->x<<" ";       
			temp = temp->Next;            
		}
		cout<<"\n";
	};     

     void Add(T x){
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


int main(){
	system("CLS");

	List<int> lst1; 
	lst1.Add(1); 
	lst1.Add(2);
	lst1.Add(5);
	lst1.Add(7);
	lst1.Add(10);
	lst1.Show(); 

	List<float> lst2; 
	lst2.Add(1.1); 
	lst2.Add(2.2);
	lst2.Add(5.5);
	lst2.Add(7.7);
	lst2.Add(10.01);
	lst2.Show(); 

	List<char> lst3; 
	lst3.Add('a'); 
	lst3.Add('b');
	lst3.Add('c');
	lst3.Add('d');
	lst3.Add('e');
	lst3.Add('f');
	lst3.Show(); 

	system("pause");
	return 0;
}