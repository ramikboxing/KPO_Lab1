//using Kpo4381_nmv.Lib.source.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kpo4381_nmv.Utility
{
  public  class CarsList
    {
        public CarsList()
        {
             this._carsList = null;
        }
      
        private List<Car> _carsList = null;

        public List<Car> Carslist { get { return _carsList; } }
        public void Execute()
        {
            _carsList = new List<Car>();
            /*Для возникновения исключения и записи в файл ErrorLog, Нужно закаментить создание списка*/
            try
            {

                {
                    // Создаем экземпляр объекта Car
                    Car car = new Car() 
                    {
                        Mark = "Toyota",
                        Model = "MarkII ",
                        Price = "350000"
                    };
                    // Помещаем в список
                    _carsList.Add(car); 
                }
                {
                    Car car = new Car()
                    {
                        Mark = "BMW ",
                        Model = "X5 ",
                        Price = "3500000"
                    };
                    _carsList.Add(car);
                }
                {
                    Car car = new Car()
                    {
                        Mark = "BMW ",
                        Model = "X3 ",
                        Price = "3200000"
                    };
                    _carsList.Add(car);
                }
            }
            catch (NotImplementedException ex)
            {
                LogUtility.ErrorLog("Lab-1 "+ex.Message); 
            }
            //Обработка остальных исключений
            catch (Exception ex) 
            {
                /* Исключение вызовет записи об ошибке в файл */
                LogUtility.ErrorLog("Lab-1 "+ex.Message);
            }
        }
    }
}
