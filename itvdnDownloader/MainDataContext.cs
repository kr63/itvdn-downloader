﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itvdnDownloader
{
    
    public class MainDataContext : INotifyPropertyChanged
    {

        private string dataVideoPageUrl = "";
        private string dataVideoLocFolder = "";
        private bool canReadSourse = true;

        [JsonIgnore]
        public ObservableCollection<LessonData> Lessons { get; set; } = new ObservableCollection<LessonData>();

        [JsonIgnore]
        public string DataVideoPageUrl
        {
            get
            {
                return dataVideoPageUrl;
            }
            set
            {
                dataVideoPageUrl = value;
                Notify(nameof(DataVideoPageUrl));
            }
        }

        public string DataVideoLocFolder
        {
            get
            {
                return dataVideoLocFolder;
            }
            set
            {
                dataVideoLocFolder = value;
                Notify(nameof(DataVideoLocFolder));
            }
        }
        [JsonIgnore]
        public bool CanReadSourse
        {
            get
            {
                return canReadSourse;
            }
            set
            {
                canReadSourse = value;
                Notify(nameof(CanReadSourse));
            }
        }

        private void Notify(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
