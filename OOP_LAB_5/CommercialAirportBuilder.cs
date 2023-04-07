using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_5
{
    public class CommercialAirportBuilder : IAirportBuilder
    {
        /// <summary>
        /// Объект возвращаемого аэропорта
        /// </summary>
        private Airport _airport = new Airport();

        /// <summary>
        /// Этап создания названия и кода аэропорта. Определение типа и соответствующих характеристик
        /// </summary>
        /// <param name="name">Название аэропорта</param>
        /// <param name="codeIATA">Код ИАТА аэропорта</param>
        /// <returns>Объект текущего строителя</returns>
        public IAirportBuilder BuildAirport(string name, string codeIATA)
        {
            _airport.Name = name;
            _airport.CodeIATA = codeIATA;
            _airport.AirportType = AirportType.Commercial;
            _airport.WithOpenAccess = true;
            return this;
        }

        /// <summary>
        /// Создает количество сотрудников в объекте аэропорта
        /// </summary>
        /// <param name="numberOfEmployees">Количество сотрудников</param>
        /// <returns>Объект текущего строителя</returns>
        public IAirportBuilder BuildEmployees(int numberOfEmployees)
        {
            _airport.NumberOfEmployees = numberOfEmployees;
            return this;
        }
        
        /// Создает самолеты в объекте аэропорта
        /// </summary>
        /// <param name="numberOfPlanes">Количество самолетов</param>
        /// <returns>Объект текущего строителя</returns>
        public IAirportBuilder BuildPlanes(int numberOfPlanes)
        {
            _airport.NumberOfPlanes = numberOfPlanes;
            return this;
        }

        /// <summary>
        /// Создает стоимость обслуживания в объекте аэропорта
        /// </summary>
        /// <param name="maintenancePrice">Стоимость обслуживания</param>
        /// <returns>Объект текущего строителя</returns>
        public IAirportBuilder BuildMaintenancePrice(decimal maintenancePrice)
        {
            _airport.MaintenancePrice = maintenancePrice;
            return this;
        }

        /// <summary>
        /// Возвращает построенный аэропорт
        /// </summary>
        /// <returns>Полученный объект аэропорта</returns>
        public Airport GetResult()
        {
            return _airport;
        }
    }
}
