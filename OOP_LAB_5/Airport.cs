using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_5
{
    public class Airport
    {
        /// <summary>
        /// Название аэропорта
        /// </summary>
        public string Name { get; set; } = "";
        /// <summary>
        /// Количество сотрудников
        /// </summary>
        public int NumberOfEmployees { get; set; }
        /// <summary>
        /// Количество самолетов
        /// </summary>
        public int NumberOfPlanes { get; set; }
        /// <summary>
        /// Код ИАТА
        /// </summary>
        public string CodeIATA { get; set; } = "";
        /// <summary>
        /// Тип аэропорта
        /// </summary>
        public AirportType AirportType { get; set; }
        /// <summary>
        /// Стоимость обслуживания
        /// </summary>
        public decimal MaintenancePrice { get; set; }
        /// <summary>
        /// Свобода доступа
        /// </summary>
        public bool WithOpenAccess { get; set; }

        override public string ToString()
        {
            return $"Name: {Name}, NumberOfEmployees: {NumberOfEmployees}, NumberOfPlanes: {NumberOfPlanes}," +
                $"CodeIATA: {CodeIATA}, AirportType: {AirportType}, MaintenancePrice: {MaintenancePrice}, WithOpenAccess: {WithOpenAccess}";
        }
    }
}
