using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace Student.Models
{
    public class StudentModel
    {
        private int _id;
        public int Id {
            get { return _id; }

            set
            {
                if (value > 0)
                    _id = value;
            }
        }
       private string _name;
        public string Name {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }
        public String City { get; set; }
    }
}
