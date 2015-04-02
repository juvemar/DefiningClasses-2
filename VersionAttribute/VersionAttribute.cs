using System;

namespace VersionAttribute
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum
        | AttributeTargets.Interface | AttributeTargets.Method, AllowMultiple = true)]
    public class VersionAttribute : Attribute
    {
        private string version;

        public string Version
        {
            get { return this.version; }
            private set { this.version = value; }
        }

        public VersionAttribute(string version)
        {
            this.Version = version;
        }
    }
}
