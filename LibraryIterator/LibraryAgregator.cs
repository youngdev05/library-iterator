

namespace LibraryIterator;

public class LibraryAgregator
{
    public readonly Book[] Library;
    

    public LibraryAgregator(int numberOfBooks)
    {
        Library = new Book[numberOfBooks];
        
        for (int i = 0; i < numberOfBooks; ++i)
        {
            var id = new Random().Next(1, 3);

            switch (id)
            {
                case 1:
                    Library[i] = new Book(id, "Adventures Of Black Boy");
                    break;
                
                case 2:
                    Library[i] = new Book(id, "Demidovich");
                    break;
                
                case 3:
                    Library[i] = new Book(id, "50 ottenkov");
                    break;
                
                default:
                    break;
            }
        }
    }

    public Iterator CreateIterator()
    {
        return new Iterator();
    }
}