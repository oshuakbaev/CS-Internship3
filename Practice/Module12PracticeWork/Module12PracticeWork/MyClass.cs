using Module12PracticeWork;

namespace Module12PracticeWork
{
    public class MyClass : iPropertychanged
    {
        private string myProperty;

        public string MyProperty
        {
            get { return myProperty; }
            set
            {
                if (myProperty != value)
                {
                    myProperty = value;
                    onPropertychanged("MyProperty");
                }
            }
        }

        public event PropertyeventHandler Propertychanged;

        protected virtual void onPropertychanged(string propertyName)
        {
            Propertychanged?.Invoke(this, new PropertyEventArgs(propertyName));
        }
    }
}
