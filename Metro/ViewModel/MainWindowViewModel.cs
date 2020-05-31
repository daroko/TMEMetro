using ControlzEx.Theming;
using MahApps.Metro.Controls.Dialogs;
using Metro.Core;
using Metro.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Metro.ViewModel
{
    public enum OperationState
    {
    Preparation,
    Start,
    End  
    }

    public class AccentColorMenuData
    {
        public string Name { get; set; }

        public Brush BorderColorBrush { get; set; }

        public Brush ColorBrush { get; set; }

        public AccentColorMenuData()
        {
            this.ChangeAccentCommand = new SimpleCommand(o => true, this.DoChangeTheme);
        }

        public ICommand ChangeAccentCommand { get; }

        protected virtual void DoChangeTheme(object sender)
        {
            ThemeManager.Current.ChangeThemeColorScheme(Application.Current, this.Name);
            ProgramSettings.Instance.curentAccentName = this.Name;
        }
        public void SetAccent(string current)
        {
            ThemeManager.Current.ChangeThemeColorScheme(Application.Current, current);
        }

    }

    public class AppThemeMenuData : AccentColorMenuData
    {
        protected override void DoChangeTheme(object sender)
        {
            ThemeManager.Current.ChangeThemeBaseColor(Application.Current, this.Name);
            ProgramSettings.Instance.curentThemeName = this.Name;
        }

        public void SetTheme(string current)
        {
            ThemeManager.Current.ChangeThemeBaseColor(Application.Current, current);
        }
    }



    public class MainWindowViewModel : ViewModelBase
    {

        #region dependencyproperty
        public static readonly DependencyProperty timeelapsedProperty
          = DependencyProperty.Register(nameof(timeelapsed),
                                        typeof(double),
                                        typeof(MainWindowViewModel),
                                        new PropertyMetadata(null));
        public double timeelapsed
        {
            get => (double)GetValue(timeelapsedProperty);
            set => SetValue(timeelapsedProperty, value);
        }
        #endregion

        #region property
        private OperationState _state = OperationState.Preparation;
        public OperationState State
        {
            get
            {
                return this._state;
            }
            set
            {
                this._state = value;
                this.OnPropertyChanged("State");
            }
        }


        private int _iloscp = 0;
        public int Iloscp
        {
            get
            {
                return this._iloscp;
            }

            set
            {

                this._iloscp = value;
                this.OnPropertyChanged("Iloscp");
            }
        }

        private int _ilosc = 0;
        public int Ilosc
        {
            get
            {
                return this._ilosc;
            }

            set
            {
                if (this._ilosc == value)
                    return;

                this._ilosc = value;
                this.GenerateNumber.CanExecute(null);
                this.OnPropertyChanged("Ilosc");
            }
        }

        private bool _progress = false;
        public bool Progress
        {
            get
            {
                return this._progress;
            }

            set
            {

                this._progress = value;
                this.OnPropertyChanged("Progress");
                this.OnPropertyChanged("ProgressBlock");

            }
        }
        public bool ProgressBlock
        {
            get { return !this._progress; }
        }

        private int _remainedNumbers = 0;
        public int RemainedNumbers
        {
            get { return this._remainedNumbers; }
            set
            {
                this._remainedNumbers = value;
                this.OnPropertyChanged("RemainedNumbers");
            }
        }

        private float _remainedPercent = 0;
        public float RemainedPercent
        {
            get { return this._remainedPercent; }
            set
            {
                this._remainedPercent = value;
                this.OnPropertyChanged("RemainedPercent");
            }
        }

        public ICommand ClearTableNumber { get; set; }

        public ICommand GenerateNumber { get; set; }

        public List<AccentColorMenuData> AccentColors { get; set; }
        public List<AppThemeMenuData> AppThemes { get; set; }

        private DbRepository reposytory = null;

        #endregion

        #region ctr
        public MainWindowViewModel()
        {
            Initialize();
        }

        private void Initialize()
        {
            ProgramSettings.Instance.conectionString = @"URI=file:" + AppDomain.CurrentDomain.BaseDirectory + "Database\\tme.db";

            reposytory = new DbRepository(new DbManager(ProgramSettings.Instance.conectionString));

            reposytory.CreateTableNumericIFNotExist();

            LeftNumbers();

            this.GenerateNumber = new SimpleCommand(o => Ilosc > 0 ? true : false, b => {  Task.Run(() => this.GenerateNumbers()); });

            this.ClearTableNumber = new SimpleCommand(o => true, b => { Task.Run(() => ClearTable()); });


            this.AccentColors = ThemeManager.Current.Themes
                                        .GroupBy(x => x.ColorScheme)
                                        .OrderBy(a => a.Key)
                                        .Select(a => new AccentColorMenuData { Name = a.Key, ColorBrush = a.First().ShowcaseBrush })
                                        .ToList();

            this.AppThemes = ThemeManager.Current.Themes
                                         .GroupBy(x => x.BaseColorScheme)
                                         .Select(x => x.First())
                                         .Select(a => new AppThemeMenuData() { Name = a.BaseColorScheme, BorderColorBrush = a.Resources["MahApps.Brushes.ThemeForeground"] as Brush, ColorBrush = a.Resources["MahApps.Brushes.ThemeBackground"] as Brush })
                                         .ToList();


            if (!string.IsNullOrEmpty(Properties.Settings.Default.Accent))
            {
                AccentColorMenuData accent = new AccentColorMenuData();
                accent.SetAccent(Properties.Settings.Default.Accent);
                ProgramSettings.Instance.curentAccentName = Properties.Settings.Default.Accent;
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Theme))
            {
                AppThemeMenuData theme = new AppThemeMenuData();
                theme.SetTheme(Properties.Settings.Default.Theme);
                ProgramSettings.Instance.curentThemeName = Properties.Settings.Default.Theme;
            }
        }
        #endregion

        #region privatefunction
        private void LeftNumbers()
        {

            if (reposytory != null)
            {
                float max = 8999999;
                float numbers = reposytory.GetUsedNumbers().Count;
                RemainedNumbers = (int)max - (int)numbers;
                if (numbers > 0)
                {
                    RemainedPercent = (numbers / max) *100;
                }
                else
                if (numbers == 0)
                    RemainedPercent = 0;
                else
                    RemainedPercent = 100;
            }
        }

        


        private void ClearTable()
        {

            if (reposytory.ClearTable())
            {
                UiInvoke(() =>
                {
                    LeftNumbers();
                    timeelapsed = 0;
                     ((MainWindow)Application.Current.MainWindow).ShowMessageAsync("Informacja", "Tabela wyczyszczona");
     
                });
            }
            return;

        }

        private void GenerateNumbers()
        {
            if (reposytory == null || RemainedNumbers == 0)
            {
                UiInvoke(()=> {
                    ((MainWindow)Application.Current.MainWindow).ShowMessageAsync("Informacja", "Tabela jest już zapełniona, w ustawieniach można ja wyczyścić");
                });
                return;
            }

            UiInvoke(() =>
            {
                ((MainWindow)Application.Current.MainWindow).Cursor = Cursors.Wait;
                Iloscp = 10;
                Progress = true;
                State = OperationState.Start;
            });
         
            var stopwatch = new Stopwatch();
            stopwatch.Start();


            List<int> usedNumber = reposytory.GetUsedNumbers();

            if (usedNumber.Count == 0)
                usedNumber = new List<int>();


            UiInvoke(() =>
            {
                Iloscp = 20;
            });


            List<int> emptyValues = new List<int>();
            emptyValues = GenerateEmptyList();

            UiInvoke(() =>
            {
                Iloscp = 40;
            });

            var listNumbertoRand = emptyValues.Except(usedNumber);
            UiInvoke(() =>
            {
                Iloscp = 60;
            });

            var numberRandom = GenerateRandomList(listNumbertoRand);
            UiInvoke(() =>
            {
                Iloscp = 80;
            });

            reposytory.NumbersInsert(numberRandom);
            UiInvoke(() =>
            {
                Iloscp = 100;
            });


            Console.WriteLine("{0} seconds .",
            stopwatch.Elapsed.TotalSeconds);

            UiInvoke(() =>
            {
                timeelapsed = stopwatch.Elapsed.TotalSeconds;
                LeftNumbers();
                Progress = false;
                State = OperationState.End;
                ((MainWindow)Application.Current.MainWindow).Cursor = Cursors.Arrow;
            });

            

        }

        private List<int> GenerateRandomList(IEnumerable<int> listNumbertoRand)
        {

            if (RemainedNumbers < Ilosc)
                Ilosc = RemainedNumbers;

            List<int> numberRandom;
            Random r = new Random();
            numberRandom = listNumbertoRand.OrderBy(x => r.Next()).Take(Ilosc).ToList();
            return numberRandom;
        }

        private List<int> GenerateEmptyList()
        {
            List<int> myValues;
            int defaultValue = 1000000;
            myValues = RangeIncrement(defaultValue, 9999999, 1);

            return myValues;
        }
        #endregion

        #region staticfunction
        public static List<int> RangeIncrement(int start, int end, int increment)
        {
            return Enumerable
                .Repeat(start, (int)((end - start) / increment) + 1)
                .Select((tr, ti) => tr + (increment * ti))
                .ToList();
        }

        public static void UiInvoke(Action a)
        {
            Application.Current.Dispatcher.Invoke(a);
        }
        #endregion



    }
}
