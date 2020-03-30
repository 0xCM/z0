namespace Z0
{
    using System;

    partial class XTend
    {
        /// <summary>
        /// Determines whether a type encodes a natural number
        /// </summary>
        /// <param name="t">The type to test</param>
        public static bool IsTypeNat(this Type t)
            => t.Realizes<ITypeNat>();
    }
}