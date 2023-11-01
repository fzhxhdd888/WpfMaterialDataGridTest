using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatagridTest
{
    public class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            UserList = new ObservableCollection<UserInfo>();
            for (int i = 0; i < 20000; i++) 
            {
                UserList.Add(new UserInfo { Name=$"Feng{i}", Age=i+1, Address=$"changsha{i+2}", Gender=$"lan{i+3}"});
            }
        }

        private ObservableCollection<UserInfo> userList;

        public ObservableCollection<UserInfo> UserList
        {
            get => userList;
            set => SetProperty(ref userList, value);
        }

    }

    public class UserInfo: ObservableObject
    {
        private string name;

        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        private int age;

        public int Age
        {
            get => age;
            set => SetProperty(ref age, value);
        }

        private string address;

        public string Address
        {
            get => address;
            set => SetProperty(ref address, value);
        }

        private string gender;

        public string Gender
        {
            get => gender;
            set => SetProperty(ref gender, value);
        }

    }
}
