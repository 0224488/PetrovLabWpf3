using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace PetrovLabWpf3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// обработка выбора названия шрифта
        /// </summary>
        private void ComboBoxFontFamily_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textbox != null) 
            {
                textbox.FontFamily = new FontFamily(fontName);
            }
        }

        /// <summary>
        /// обработка выбора размера шрифта
        /// </summary>
        private void ComboBoxFontSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontSize = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if(textbox != null)
            {
                textbox.FontSize = int.Parse(fontSize);
            }
        }

        /// <summary>
        /// обработка выбора цвета текста
        /// </summary>
        private void RadioButtonColor_Checked(object sender, RoutedEventArgs e)
		{
            if(textbox != null)
            {
                var radioButton = sender as RadioButton;
                if(radioButton != null)
                {
                    textbox.Foreground = radioButton.Foreground;
                }
            }
        }

        /// <summary>
        /// обработка выбора стиля шрифта (жирный, обычный)
        /// </summary>
        private void ToggleButtonBold_CheckedChanged(object sender, RoutedEventArgs e)
		{
            var toggleButton = sender as ToggleButton;
			if(toggleButton != null)
			{
				if(toggleButton.IsChecked == true)
					textbox.FontWeight = FontWeights.Bold;
                else
                    textbox.FontWeight = FontWeights.Normal;
            }
        }

        /// <summary>
        /// обработка выбора стиля шрифта (курсив, обычный)
        /// </summary>
        private void ToggleButtonItalic_CheckedChanged(object sender, RoutedEventArgs e)
        {
            var toggleButton = sender as ToggleButton;
            if(toggleButton != null)
            {
                if(toggleButton.IsChecked == true)
                    textbox.FontStyle = FontStyles.Italic;
                else
                    textbox.FontStyle = FontStyles.Normal;
            }
        }

        /// <summary>
        /// обработка выбора стиля шрифта (подчеркнутый, обычный)
        /// </summary>
        private void ToggleButtonUnderline_CheckedChanged(object sender, RoutedEventArgs e)
        {
            var toggleButton = sender as ToggleButton;
            if(toggleButton != null)
            {
                if(toggleButton.IsChecked == true)
                    textbox.TextDecorations = TextDecorations.Underline;
                else
                    textbox.TextDecorations = null;
            }
        }
    }
}
