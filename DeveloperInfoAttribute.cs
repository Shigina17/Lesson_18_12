using System;

namespace Lesson_18_12
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Struct, AllowMultiple = true)] //добавляем атрибут
    class DeveloperInfoAttribute : System.Attribute
    {
        private string developerName;
        private string dateCreated;

        public DeveloperInfoAttribute(string developerName)
        {
            this.developerName = developerName;
        }

        public string Developer { get => developerName; }
        public string Date { get => dateCreated; set => dateCreated = value; }
    }
}
