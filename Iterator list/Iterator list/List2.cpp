#include "List2.h"
#include <iostream>
#include <memory>


List2::List2(std::initializer_list<int> values) :
    size(values.size()),
    data(new int[size])
{
    std::copy(values.begin(), values.end(), data.get());
}


List2::iterator List2::begin(){
    return iterator(data.get());
}

List2::iterator List2::end(){
    return iterator(data.get() + size);
}

List2::const_iterator List2::begin() const{
    return const_iterator(data.get());
}

List2::const_iterator List2::end() const{
    return const_iterator(data.get() + size);
}