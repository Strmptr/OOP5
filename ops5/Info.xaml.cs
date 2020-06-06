using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ops5
{
    /// <summary>
    /// Логика взаимодействия для Info.xaml
    /// </summary>
    public partial class Info : UserControl
    {
        public Info()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty PNameProperty = DependencyProperty.Register(
            "PName",
            typeof(string),
            typeof(Info),
            new PropertyMetadata(string.Empty, PNameChanged));

        public string PName
        {
            get { return (string)GetValue(PNameProperty); }
            set { SetValue(PNameProperty, value); }
        }

        private static void PNameChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var PNameForm = obj as Info;
            PNameForm.Name.Text = PNameForm.PName;
        }

        public static readonly DependencyProperty PCompanyProperty = DependencyProperty.Register(
            "PCompany",
            typeof(string),
            typeof(Info),
            new PropertyMetadata(string.Empty, PCompanyChanged));

        public string PCompany
        {
            get { return (string)GetValue(PCompanyProperty); }
            set { SetValue(PCompanyProperty, value); }
        }

        private static void PCompanyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var PCompanyForm = obj as Info;
            PCompanyForm.Company.Text = PCompanyForm.PCompany;
        }

        public static readonly DependencyProperty PNumberProperty = DependencyProperty.Register(
            "PNumber",
            typeof(string),
            typeof(Info),
            new PropertyMetadata(string.Empty, PNumberChanged));

        public string PNumber
        {
            get { return (string)GetValue(PNumberProperty); }
            set { SetValue(PNumberProperty, value); }
        }

        private static void PNumberChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var PNumberForm = obj as Info;
            PNumberForm.Phone.Text = PNumberForm.PNumber;
        }

        public static readonly DependencyProperty PimgProperty = DependencyProperty.Register(
           "Pimg",
           typeof(ImageSource),
           typeof(Info),
           new PropertyMetadata(ImgChanged));

        public ImageSource Pimg
        {
            get { return (ImageSource)GetValue(PimgProperty); }
            set { SetValue(PimgProperty, value); }
        }

        private static void ImgChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var PimgForm = obj as Info;
            PimgForm.Image.Source = PimgForm.Pimg;
        }
    }
}
