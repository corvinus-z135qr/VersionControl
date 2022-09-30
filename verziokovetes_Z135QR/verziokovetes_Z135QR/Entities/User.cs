using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verziokovetes_Z135QR.Entities
{
    internal class User
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        /* public string FirstName { get; set; }
         public string LastName { get; set; } */
        public string FullName { get; set; }
        
        }

      
    }

