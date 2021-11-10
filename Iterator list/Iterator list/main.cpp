#include <iostream>
#include "List3.h"


using namespace std;

int main() {
	List3 lst;
	lst.Add(1);
	lst.Add(2);
	lst.Add(5);
	lst.Add(7);
	lst.Add(10);
	lst.Add(3);
	lst.Show();


	for (auto i = lst.begin(); i != NULL; ++i) {
		cout << *i << " ";
	}
	cout << endl << endl;

	auto it = lst.begin();

	cout << *it << endl;
	cout << *it++ << endl;
	cout << *it << endl;
	cout << *it-- << endl;
	cout << *it << endl;

	cout << endl << endl;
	it = lst.begin();
	++it;
	++it;
	++it;
	lst.Insert(it, 99);
	lst.Show();
	it = lst.end();
	lst.Insert(it, 99);
	lst.Show();

	it = lst.begin();
	++it;
	lst.Erase(it);
	lst.Show();

	it = lst.end();
	lst.Erase(it);
	lst.Show();

	system("pause");
	return 0;
}