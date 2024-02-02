namespace task2;

public class PhotoBook
{
    int _numPages {get; set;}

    public virtual int GetNumerPages()
    {
        return _numPages;
    } 
    public PhotoBook(){}
   public PhotoBook(int page)
   {
    _numPages = page;
   }
}
