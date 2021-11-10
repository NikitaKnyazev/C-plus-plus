#ifndef ITERATOR_H
#define ITERATOR_H
#include "List.h"
 
class Iterator{
public:
    friend class List;
 
    Iterator();
    Iterator operator ++ ();
    Iterator operator -- ();
	begin();
	end();
	int operator * ();
    /*{
        if(ptr)
            return ptr->x;        
    }*/
    int operator -> ();
    /*{
        if(ptr)
            return ptr->x;        
    }*/

private:
   List::Node *ptr;

}

#endif
