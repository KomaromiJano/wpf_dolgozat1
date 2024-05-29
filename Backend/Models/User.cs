using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Backend.Models;

public class User:INotifyPropertyChanged
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    private int id;

    public int Id
    {
        get { return id; }
        set
        {
            id = value;
            OnPropertyChanged();
        }
    }

    private String name;
    public String Name
    {
        get { return name; }
        set { 
            name = value;
            OnPropertyChanged();
        }
    }

    private int age;
    public int Age
    {
        get { return age; }
        set { 
            age = value;
            OnPropertyChanged();
        }
    }

    private String nationality;

    public String Nationality
    {
        get { return nationality; }
        set
        {
            nationality = value;
            OnPropertyChanged();
        }
    }

    private String profession;
    public String Profession
    {
        get { return profession; }
        set
        {
            profession = value;
            OnPropertyChanged();
        }
    }
        
    private String interests;
    public String Insterests
    {
        get { return interests; }
        set
        {
            interests = value;
            OnPropertyChanged();
        }
    }


    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName]string propertyName=null) { 
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public User()
    {
           
    }

    public User(String[] data)
    {
        try
        {
            Name = data[0];
            Age = int.Parse(data[1]);
            Nationality = data[2];
            Profession = data[3];
            Insterests = data[4];
        }
        catch (FormatException)
        {
            Console.WriteLine($"Unable to parse one or more fields in the data array.");
        }
    }

    public override string? ToString()
    {
        return $"{Name} {Age} {Nationality} {Profession} {Insterests}";
    }
}