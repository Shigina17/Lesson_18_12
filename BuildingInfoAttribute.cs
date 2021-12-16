using System;

namespace Lesson_18_12
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Struct, AllowMultiple = true)] //добавляем атрибут
    class BuildingInfoAttribute : System.Attribute
    {
        public string organization;
        private string nameOfDeveloper;
 
        public BuildingInfoAttribute(string nameOfDeveloper, string organization)
        {
            this.nameOfDeveloper = nameOfDeveloper;
            this.organization = organization;
        }
        public string Developer { get => nameOfDeveloper; }
        public string Organization { get => organization; set => organization = value; }
    }
}
