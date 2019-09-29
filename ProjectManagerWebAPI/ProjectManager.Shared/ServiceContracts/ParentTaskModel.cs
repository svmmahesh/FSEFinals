using System;
using System.Runtime.Serialization;

namespace ProjectManager.Shared.ServiceContracts
{
    [DataContract]
    public class ParentTaskModel
    {
        [DataMember(Name = "parentId")]
        public int Parent_ID { get; set; }

        [DataMember(Name = "parentTaskName")]
        public string ParentTaskName { get; set; }
    }
}
