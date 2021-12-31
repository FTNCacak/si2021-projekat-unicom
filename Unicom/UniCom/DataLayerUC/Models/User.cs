using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerUC.Models
{
    public class User
    {
    public int UserID { get; set; }
    public string username { get; set; }
    public string First_Name { get; set; }
    public string Last_Name { get; set; }
    public bool Gender { get; set; }
    public bool Student { get; set; }
    public bool Mentor { get; set; }
    public bool Administration { get; set; }
    public string Profession { get; set; }
    }
}
