using System;

namespace Module12PracticeWork
{
    // Делегат, используемый для события изменения свойства
    public delegate void PropertyeventHandler(object sender, PropertyEventArgs e);

    // Класс EventArgs, который несет информацию о свойстве, которое изменилось
    public class PropertyEventArgs : EventArgs
    {
        public string PropertyName { get; private set; }

        public PropertyEventArgs(string propertyName)
        {
            PropertyName = propertyName;
        }
    }

    // Интерфейс, который должен быть реализован классами, желающими уведомлять об изменении свойств
    public interface iPropertychanged
    {
        event PropertyeventHandler Propertychanged;
    }
}
