﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SchoolPaper.Command;
using SchoolPaper.View;

namespace SchoolPaper.ViewModel;

public class MainViewModel:INotifyPropertyChanged
{
    private object currentView;

    public object CurrentView
    {
        get { return currentView; }
        set { 
            currentView = value;
            OnPropertyChanged();
        }
    }

    Task1 task1;
    Task2 task2;
    Task3 task3;

    public event PropertyChangedEventHandler? PropertyChanged;		

    public RelayCommand openHome { get; }
    public RelayCommand openTask1 { get; } 
    public RelayCommand openTask2 { get; }
    public RelayCommand openTask3 { get; }

    public MainViewModel()
    {
        task1 = new Task1();
        task2 = new Task2();
        task3 = new Task3();

        //openHome = new RelayCommand(X=> CurrentView=homeView);
        openTask1 = new RelayCommand(X=> CurrentView=task1);
        openTask2 = new RelayCommand(X=> CurrentView=task2);
        openTask3 = new RelayCommand(X=> CurrentView=task3);

        CurrentView = task1;
    }

    private void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}