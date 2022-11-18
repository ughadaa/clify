using System;
namespace clify.Models
{
    public class CommandModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string des { get; set; }

        public CommandModel()
        {

        }
        public CommandModel(int id, string name, string des)
        {
            this.id = id;
            this.name = name;
            this.des = des;

        }
    }
}

