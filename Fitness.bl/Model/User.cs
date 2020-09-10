using System;

namespace Fitness.bl.Model
{/// <summary>
/// Пользователь
/// </summary>
   public class User
    {
        #region Свойства
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Пол
        /// </summary>
        public Gender Gender { get; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime BirthDate { get; }
        /// <summary>
        /// Вес
        /// </summary>
        public double Weigth { get; set; }
        /// <summary>
        /// Рост
        /// </summary>
        public double Height { get; set; }
        #endregion 
        /// <summary>
        /// Создать нового пользователя
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="gender">Пол</param>
        /// <param name="birhtDate">Дата рождения</param>
        /// <param name="weigth">Вес</param>
        /// <param name="height">Рост</param>
        public User(string name,Gender gender, DateTime birhtDate,double weigth, double height)
        {
            #region Проверка условий
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым или null", nameof(name));
            }
            if(Gender == null)
            {
                throw new ArgumentNullException("Пол не может быть null", nameof(gender));
            }
            if(birhtDate<DateTime.Parse("01.01.1900") || birhtDate >=DateTime.Now)
            {
                throw new ArgumentNullException("Невозможная дата рождения", nameof(birhtDate));
            }
            if(weigth<=0)
            {
                throw new ArgumentNullException("Вес не может быть меньше лиьо равен 0", nameof(weigth));
            }
            if(height<=0)
            {
                throw new ArgumentNullException("Рост не может быть меньше или равен нулю", nameof(height));
            }
            #endregion

            Name = name;
            Gender = gender;
            BirthDate = birhtDate;
            Weigth = weigth;
            Height = height;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
