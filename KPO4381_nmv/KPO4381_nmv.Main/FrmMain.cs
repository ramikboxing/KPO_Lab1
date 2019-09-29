using Kpo4381_nmv;
using Kpo4381_nmv.Utility;
using KPO4381_nmv.Main.source;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KPO4381_nmv.Main
{
    public partial class FrmMain : Form
    {
        //private List<Car> carList = null;
        private BindingSource bsCars = new BindingSource();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            Close();          
        }
        /*Открыть список машин*/
        private void mnOpen_Click(object sender, EventArgs e)
        {

            try
            {
                /* Создаем объект который содержит метод
                 * который записывает экземпляры класса Car в список*/
                CarsList loader = new CarsList();
                
                /*Вызывается этот метод и формируем список*/
                loader.Execute(); 

                bsCars.DataSource = loader.Carslist;

                /*dvgCarList - имя компаента DataGridView*/
                dgvCarList.DataSource = bsCars;
                
            }
            //Обработка исключения "Метод не реализован"
            catch(NotImplementedException ex)
            {
                MessageBox.Show("Ошибка №1:" + ex.Message);
               LogUtility.ErrorLog(ex.Message);
            }
            //Обработка остальных исключений
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка №2:" + ex.Message);
                LogUtility.ErrorLog(ex.Message);
            }
        }
        /*Открыть машину*/
        private void mnOpenCars_Click(object sender, EventArgs e)
        {
            try
            {
                //Создать экземпляр формы
                FrmCar frmCar = new FrmCar();
                //Задать ссылку на текущий объект в таблице
                Car car = (bsCars.Current as Car);
                frmCar.SetCar(car);

                //Open Form2
                frmCar.ShowDialog();
            }
            catch (NotImplementedException ex)
            {
                MessageBox.Show("Ошибка №3:" + ex.Message);
            }
        }
    }
}
