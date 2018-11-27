namespace RentidaCar2.Model
{
    public class Payment
    {
        private string id;
        private string methodName;

        public Payment(string id, string methodName)
        {
            this.Id = id;
            this.MethodName = methodName;
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string MethodName
        {
            get
            {
                return methodName;
            }

            set
            {
                methodName = value;
            }
        }
    }
}
