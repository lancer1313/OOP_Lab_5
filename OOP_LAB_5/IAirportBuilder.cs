using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_5
{
    /// <summary>
    /// Интерфейс для строительства объектов класса Airport
    /// </summary>
    public interface IAirportBuilder
    {
        /// <summary>
        /// Этап создания названия и кода аэропорта
        /// </summary>
        /// <param name="name">Название аэропорта</param>
        /// <param name="codeIATA">Код ИАТА аэропорта</param>
        /// <returns>Объект текущего строителя</returns>
        public IAirportBuilder BuildAirport(string name, string codeIATA);
        /// <summary>
        /// Создает количество сотрудников в объекте аэропорта
        /// </summary>
        /// <param name="numberOfEmployees">Количество сотрудников</param>
        /// <returns>Объект текущего строителя</returns>
        public IAirportBuilder BuildEmployees(int numberOfEmployees);
        /// <summary>
        /// Создает самолеты в объекте аэропорта
        /// </summary>
        /// <param name="numberOfPlanes">Количество самолетов</param>
        /// <returns>Объект текущего строителя</returns>
        public IAirportBuilder BuildPlanes(int numberOfPlanes);
        /// <summary>
        /// Создает стоимость обслуживания в объекте аэропорта
        /// </summary>
        /// <param name="maintenancePrice">Стоимость обслуживания</param>
        /// <returns>Объект текущего строителя</returns>
        public IAirportBuilder BuildMaintenancePrice(decimal maintenancePrice);
        /// <summary>
        /// Возвращает построенный аэропорт
        /// </summary>
        /// <returns>Полученный объект аэропорта</returns>
        public Airport GetResult();
    }
}
