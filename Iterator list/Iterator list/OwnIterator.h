#ifndef OWNITERATOR_H
#define OWNITERATOR_H
#include "List2.h"

template<typename ValueType>
class OwnIterator: public std::iterator<std::input_iterator_tag, ValueType>
{
    friend class List2;
private:
    OwnIterator(ValueType* p);
	ValueType* p;

public:
    OwnIterator(const OwnIterator &it);
    bool operator!=(OwnIterator const& other) const;
    bool operator==(OwnIterator const& other) const; 
    typename OwnIterator::reference operator*() const;
    OwnIterator& operator++();    
};
#endif