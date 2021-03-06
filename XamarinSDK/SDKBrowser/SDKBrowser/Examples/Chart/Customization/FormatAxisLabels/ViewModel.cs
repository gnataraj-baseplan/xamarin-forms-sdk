﻿using System.Collections.ObjectModel;

namespace SDKBrowser.Examples.Chart.Customization.FormatAxisLabels
{
    public class ViewModel
    {
        public ObservableCollection<TemporalData> Data { get; private set; }

        public ViewModel()
        {
            this.Data = new ObservableCollection<TemporalData>(DataProvider.GetDateTimeData(6));
        }
    }
}
