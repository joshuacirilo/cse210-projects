using System;
class Video
{
    private string _title;
    private string _author;
    private  double _length;

    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public string GetInformationOfVideo()
    {
        string completeInformation = ($"Title: {_title}, Author: {_author}, Length in seconds : {_length}");
        return completeInformation;
    }





}