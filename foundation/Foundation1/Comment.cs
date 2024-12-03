using System;
using System.Diagnostics.Contracts;
class Comment
{

    private string _comment;
    private string _nameOfPerson; 

    public Comment ( string Name, string comment)
    {
        _comment = comment;
        _nameOfPerson = Name;

    }

    public string GetInformationOfComment()
    {
        string completeInformation = ($"Name: {_nameOfPerson}, Comment: {_comment}");

        return completeInformation; 
    }
    
}