﻿namespace Lands.ViewModels
{
    using System;
    using System.Collections.ObjectModel;
    using System.Linq;
    using Lands.Models;

    public class LandViewModel : BaseViewModel
    {
        #region Attributes

        private ObservableCollection<Border> borders;
        private ObservableCollection<Currency> currencies;
        private ObservableCollection<Language> languages;

        #endregion

        #region Properties

        public Land Land { get; set; }

        public ObservableCollection<Border> Borders
        {
            get { return this.borders; }
            set { SetValue(ref this.borders, value); }
        }

        public ObservableCollection<Currency> Currencies
        {
            get { return this.currencies; }
            set { SetValue(ref this.currencies, value); }
        }

        public ObservableCollection<Language> Languages
        {
            get { return this.languages; }
            set { SetValue(ref this.languages, value); }
        }
        #endregion

        #region Constructor

        public LandViewModel(Land land)
        {
            this.Land = land;
            this.LoadBorders();
            this.Currencies = new ObservableCollection<Currency>(this.Land.Currencies);
            this.Languages = new ObservableCollection<Language>(this.Land.Languages);
        }

        #endregion

        #region Methods


        private void LoadBorders()
        {
            this.Borders = new ObservableCollection<Border>();
            if (this.Land.Borders != null)
            {
                foreach (var border in this.Land.Borders)
                {
                    var land = MainViewModel.GetInstance().LandsList.Where(l =>
                    l.Alpha3Code.Equals(border)).FirstOrDefault();
                    if (land != null)
                    {
                        this.Borders.Add(new Border
                        {
                            Code = land.Alpha3Code,
                            Name = land.Name
                        });
                    }
                }
            }
        }

        #endregion
    }
}