#include <iostream>
#include <algorithm>
#include <cstdlib>
#include "OwnList.h"


using namespace std;

int main() {
	srand(123);
	OwnList lst;
	lst.Add(rand() % 1000);
	lst.Add(rand() % 1000);
	lst.Add(rand() % 1000);
	lst.Add(rand() % 1000);
	lst.Add(rand() % 1000);
	lst.Add(rand() % 1000);
	lst.Add(rand() % 1000);
	lst.Add(rand() % 1000);
	lst.Add(rand() % 1000);
	lst.Add(rand() % 1000);
	lst.Add(rand() % 1000);
	lst.Add(rand() % 1000);
	lst.Add(rand() % 1000);
	lst.Add(rand() % 1000);
	lst.Add(rand() % 1000);
	lst.Add(rand() % 1000);
	lst.Add(rand() % 1000);
	lst.Add(rand() % 1000);

	auto it = lst.begin();
	++it;
	++it;
	lst.Insert(it, 7);
	cout << "List:\n";
	lst.Show();

	cout << endl;
	lst.LinearSearch(7);
	lst.LinearSearch(965);

	cout << endl;
	lst.sort();
	cout << "Sorted list:\n";
	lst.Show();
	
	cout << endl;
	system("pause");
	return 0;
}