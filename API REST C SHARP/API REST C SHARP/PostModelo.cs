using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace API_REST_C_SHARP
{
    [DataContract]
    class PostModelo
    {
            [DataMember(Name = "userId")]
            public string userId { get; set; }

            [DataMember(Name = "id")]
            public string id { get; set; }

            [DataMember(Name = "title")]
            public string title { get; set; }

            [DataMember(Name = "body")]
            public string body { get; set; }
        
    }
}
