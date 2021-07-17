#include<iostream>
#include<stdlib.h>
using namespace std;
int main()
{
	/*
	This is the update from the MiniPC 
	*/
	int ProgramStatus=1;
	while(ProgramStatus==1)
	{
		system("CLS"); //This line is to clean the screen.
		int choice, limit;
		cout<<"Enter the Number to print the table";
		cin>>choice;
		cout<<"Enter table limit";
		cin>>limit;
		for(int i =1; i<=limit; i++)
		{
			cout<<choice<<" x "<<i<<" ="<<i*choice<<endl;
		}
	cout<<"Do you want to print any other table\nPress 1 to Continue any other key to exit...";
	cin>>ProgramStatus;
}
}
