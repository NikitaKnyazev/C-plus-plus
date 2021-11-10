#include "Iterator.h"
#include <iostream>

int Iterator::operator * (){
        if(ptr)
            return ptr->x;        
    }

int Iterator::operator -> (){
        if(ptr)
            return ptr->x;        
    }