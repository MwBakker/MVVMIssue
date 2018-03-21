using System.Collections.Generic;
using System.Collections.ObjectModel;
using transactionReaderWPF.ViewModel;
using WPFMVVMTabCtrl.Model;

namespace WPFMVVMTabCtrl.ViewModel
{
    class Tab2VM : BaseVM
    {
        public string Header { get; set; }

        // this List is hypothetically used in a ListView
        // foreach is required(?) to call on the Inotify(?) 
        public ObservableCollection<SharedModel> SharedList { get; set; }
    }
}
