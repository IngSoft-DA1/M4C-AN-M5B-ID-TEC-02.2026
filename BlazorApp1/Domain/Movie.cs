namespace Domain;

public class Movie
{
    public int Id  { get; set; }
    public string Name {
        get
        {
            return _name;
        }
        set
        {
            if (value == "")
            {
                throw new ArgumentException("Movie name can't be empty");
            }

            _name = value;
        }
    }

    public DateTime ReleaseDate {
        get { return _releaseDate; }
        set
        {
            _releaseDate = value;
        }
    }

    public string ShortDescription {
        get
        {
            return _shortDescription; 
        }
        set {
            if (value == "")
            {
                throw new ArgumentException("Movie short description can't be empty");
            } 
            _shortDescription = value; 
        }
    }
    

    private string _name;
    private DateTime _releaseDate;
    private string _shortDescription;

    public Movie()
    {
        
    }
    public Movie(string name, DateTime releaseDate, string shortDescription)
    {
        
    }
}