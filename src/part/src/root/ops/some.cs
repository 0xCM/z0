// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct root
    {
        /// <summary>
        /// Defines a valued option
        /// </summary>
        /// <param name="value">The value</param>
        /// <typeparam name="T">The type of the extant value</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Option<T> some<T>(T value)
            => Option<T>.Some(value);
    }
}