// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct root
    {
        /// <summary>
        /// Defines a non-valued option
        /// </summary>
        /// <typeparam name="T">The value type, if the value existed</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static bool nonz<T>(T src)
            where T : unmanaged
                => !src.Equals(default(T));
    }
}