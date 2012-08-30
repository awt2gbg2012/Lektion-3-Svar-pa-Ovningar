using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lektion3SvarOvningar.Extension_Methods
{
    public static class ExtensionMethods
    {
        public static bool In<T>(this T source, params T[] list)
        {
            if (null == source) throw new ArgumentNullException("source");
            return list.Contains(source);
        }
    }
}
