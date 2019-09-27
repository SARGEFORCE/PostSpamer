using System.Collections;
using System.Windows;
using System.Windows.Input;

namespace PostSpamer.controls
{
    public partial class Tool3Controller
    {
        #region ItemsProperty : IEnumerable - Элементы списка
        public static readonly DependencyProperty ItemsProperty = 
            DependencyProperty.Register(
                nameof(Items),
                typeof(IEnumerable),
                typeof(Tool3Controller),
                new PropertyMetadata(default(IEnumerable), OnItemsChanged, ItemsCoerceValue),
                ItemsValidate
            );
        public IEnumerable Items
        {
            get => (IEnumerable)GetValue(ItemsProperty);
            set => SetValue(ItemsProperty, value);
        }
        private static bool ItemsValidate(object value) { return true; }
        private static object ItemsCoerceValue(DependencyObject d, object baseValue){  return baseValue; }
        private static void OnItemsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e){  }
        
        #endregion

        #region SelectedItem : object - Выбранный элемент
        public static readonly DependencyProperty SelectedItemProperty =
            DependencyProperty.Register(
                nameof(SelectedItem),
                typeof(object),
                typeof(Tool3Controller),
                new PropertyMetadata(default(object)));
        public object SelectedItem
        {
            get => (IEnumerable)GetValue(SelectedItemProperty);
            set => SetValue(SelectedItemProperty, value);
        }
        #endregion

        #region PanelName : string - Название панели
        public static readonly DependencyProperty PanelNameProperty =
            DependencyProperty.Register(
                nameof(PanelName),
                typeof(string),
                typeof(Tool3Controller),
                new PropertyMetadata(default(object)));
        public string PanelName
        {
            get => (string)GetValue(PanelNameProperty);
            set => SetValue(PanelNameProperty, value);
        }
        #endregion

        #region SelectedIndex : int - Индекс выбранного элемента
        public static readonly DependencyProperty SelectedIndexProperty=
            DependencyProperty.Register(
                nameof(SelectedIndex),
                typeof(int),
                typeof(Tool3Controller),
                new PropertyMetadata(default(int)));
        public int SelectedIndex
        {
            get => (int)GetValue(SelectedIndexProperty);
            set => SetValue(SelectedIndexProperty, value);
        }
        #endregion

        #region ViewPropertyPath : string - Имя отображаемого свойства
        public static readonly DependencyProperty ViewPropertyPathProperty =
            DependencyProperty.Register(
                nameof(ViewPropertyPath),
                typeof(string),
                typeof(Tool3Controller),
                new PropertyMetadata(default(string)));
        public string ViewPropertyPath
        {
            get => (string)GetValue(ViewPropertyPathProperty);
            set => SetValue(ViewPropertyPathProperty, value);
        }
        #endregion

        #region ValuePropertyPath: string - Имя свойства значения
        public static readonly DependencyProperty ValuePropertyPathProperty =
            DependencyProperty.Register(
                nameof(ValuePropertyPath),
                typeof(string),
                typeof(Tool3Controller),
                new PropertyMetadata(default(string)));
        public string ValuePropertyPath
        {
            get => (string)GetValue(ValuePropertyPathProperty);
            set => SetValue(ValuePropertyPathProperty, value);
        }
        #endregion

        #region ItemTemplate: DataTemplate - Шаблон визуализации данных
        public static readonly DependencyProperty ItemTemplateProperty =
            DependencyProperty.Register(
                nameof(ItemTemplate),
                typeof(DataTemplate),
                typeof(Tool3Controller),
                new PropertyMetadata(default(string)));
        public DataTemplate ItemTemplate
        {
            get => (DataTemplate)GetValue(ItemTemplateProperty);
            set => SetValue(ItemTemplateProperty, value);
        }
        #endregion

        #region CreateCommand : ICommand - Команда создания нового значения
        public static readonly DependencyProperty CreateCommandProperty =
            DependencyProperty.Register(
                nameof(CreateCommand),
                typeof(ICommand),
                typeof(Tool3Controller),
                new PropertyMetadata(default(ICommand)));

        public ICommand CreateCommand
        {
            get => (ICommand)GetValue(CreateCommandProperty);
            set => SetValue(CreateCommandProperty, value);
        }
        #endregion

        #region EditCommand : ICommand - Команда редактирования значения
        public static readonly DependencyProperty EditCommandProperty =
            DependencyProperty.Register(
                nameof(EditCommand),
                typeof(ICommand),
                typeof(Tool3Controller),
                new PropertyMetadata(default(ICommand)));

        public ICommand EditCommand
        {
            get => (ICommand)GetValue(CreateCommandProperty);
            set => SetValue(CreateCommandProperty, value);
        }
        #endregion

        #region DeleteCommand : ICommand - Команда удаления значения
        public static readonly DependencyProperty DeleteCommandProperty =
            DependencyProperty.Register(
                nameof(DeleteCommand),
                typeof(ICommand),
                typeof(Tool3Controller),
                new PropertyMetadata(default(ICommand)),
                ItemsValidate
            );

        public ICommand DeleteCommand
        {
            get => (ICommand)GetValue(DeleteCommandProperty);
            set => SetValue(DeleteCommandProperty, value);
        }
        #endregion

        #region ComboBoxVisibility : Visibility - Свойство видимости

        public static readonly DependencyProperty ComboBoxVisibilityProperty =
            DependencyProperty.Register(
                nameof(ComboBoxVisibility),
                typeof(Visibility),
                typeof(Tool3Controller),
                new PropertyMetadata(default(Visibility)));

        public Visibility ComboBoxVisibility
        {
            get => (Visibility)GetValue(ComboBoxVisibilityProperty);
            set => SetValue(ComboBoxVisibilityProperty, value);            
        }
        #endregion

        public Tool3Controller() => InitializeComponent();
    }

}
