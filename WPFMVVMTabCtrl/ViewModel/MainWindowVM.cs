using System.Collections.Generic;
using System.Collections.ObjectModel;
using transactionReaderWPF.ViewModel;
using WPFMVVMTabCtrl.Model;

namespace WPFMVVMTabCtrl.ViewModel
{
    class MainWindowVM
    {
        public ObservableCollection<BaseVM> Tabs { get; set; }
        public BaseVM SelectedTab { get; set; }
        ObservableCollection<SharedModel> mainList; 


        public MainWindowVM()
        {
            mainList = new ObservableCollection<SharedModel>();

            Tabs = new ObservableCollection<BaseVM>
            {
                new Tab1VM() { SharedList = mainList, Header = "Tab A" },
                new Tab2VM() { SharedList = mainList, Header = "Tab B" }
            };

            SelectedTab = Tabs[0];
        }

        // must shared list be in the constructor in order to perform the foreach and .Add, 
        // so the Inotify on ObservableCollection gets called on? 
    }
}
