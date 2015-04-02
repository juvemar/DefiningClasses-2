using System;

namespace VersionAttribute
{
    [VersionAttribute("2.11")]
    class VersionMain
    {
        static void Main()
        {
            Type type = typeof(VersionMain);
            object[] attributes = type.GetCustomAttributes(false);

            foreach (VersionAttribute attribute in attributes)
            {
                Console.WriteLine(attribute.Version);
            }
        }
    }
}
