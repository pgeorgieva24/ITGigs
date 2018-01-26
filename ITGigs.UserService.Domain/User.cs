using ITGigsCommon;
using System;
using System.ComponentModel.DataAnnotations;

namespace ITGigs.UserService.Domain
{
    public class User
    {
        public User(string name)
        {
            this.Id = new CustomId().ToString();
            this.Name = name;
            this.DateChanged = DateTime.Now;
        }

        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateChanged { get; set; }

    }
}
