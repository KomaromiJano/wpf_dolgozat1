using System.Collections.ObjectModel;
using System.Windows.Controls;

using Backend.Data;
using Backend.Models;
using System.Linq;
using System.Windows;

namespace SchoolPaper.View;

public partial class Task3 : UserControl
{
    public ObservableCollection<User> Users;
    public UsersContext db;
    public Task3()
    {
        InitializeComponent();
        Users = new ObservableCollection<User>();
        db = new UsersContext();
        RefleshUsers();
        lbUsers.ItemsSource = Users;
        spInput.DataContext = Users;
    }
    
    private void RefleshUsers()
    {
        Users.Clear();
        if (db.Users.Any())
        {
            foreach (var user in db.Users)
            {
                Users.Add(user);
            }
        } else Users.Add(new User());
    }
    
    private void Add_Click(object sender, RoutedEventArgs e)
    {
        User user = lbUsers.SelectedItem as User;

        if (user.Name!=null)
        {
            user.Id = 0;
            db.Users.Add(user);
            db.SaveChanges();

            RefleshUsers();
            lbUsers.SelectedItem = user;
        }
    }

    private void Update_Click(object sender, RoutedEventArgs e)
    {
        User user = lbUsers.SelectedItem as User;
        if (user.Name != null)
        {              
            db.Users.Update(user);
            db.SaveChanges();
            RefleshUsers();
            lbUsers.SelectedItem = user;
        }
    }

    private void Delete_Click(object sender, RoutedEventArgs e)
    {
        User user = lbUsers.SelectedItem as User;
        if (user != null && user.Id!=0)
        {
            int index = lbUsers.SelectedIndex;
            db.Users.Remove(user);
            db.SaveChanges();
            RefleshUsers();
            lbUsers.SelectedIndex= index<lbUsers.Items.Count?index:lbUsers.Items.Count-1;
        }
    }
    
}