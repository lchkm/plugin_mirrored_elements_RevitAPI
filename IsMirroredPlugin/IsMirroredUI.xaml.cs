using System;
using System.Windows;


namespace IsMirroredPlugin
{
    /// <summary>
    /// Логика взаимодействия для IsMirroredUI.xaml
    /// </summary>
    public partial class IsMirroredUI : Window
    {
        private int sumOfMirroredElements;


        /// <summary>
        /// Создали инициализатор нового окна
        /// </summary>
        /// <param name="countOfMirroredElements"></param>
        public IsMirroredUI(int countOfMirroredElements)
        {
            InitializeComponent();
            sumOfMirroredElements = countOfMirroredElements;

        }

        /// <summary>
        /// Создали обработчик нажатия на кнопку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CheckForMirrored_Click(object sender, RoutedEventArgs e)
        {
            if (sumOfMirroredElements == 0)
            {
                MessageBox.Show("Отзеркаленных элементов нет!");
            }
            else
            {
                MessageBox.Show($"Кол-во отзеркаленных элементов: {sumOfMirroredElements}");
            }

        }

    }
}
       