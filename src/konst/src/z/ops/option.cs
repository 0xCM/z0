//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Defines an option for a reference type; a valued option is produced if the source is non-null; otherwise, a non-valued option is produced
        /// </summary>
        /// <param name="src">A source value, or null</param>
        /// <typeparam name="T">The enclosed type</typeparam>
        [MethodImpl(Inline)]
        public static Option<T> option<T>(T src)
            where T : class
                => Option.from(src);

        /// <summary>
        /// Defines an option for a nullable value type; a valued option is produced if the source is non-null; otherwise, a non-valued option is produced
        /// </summary>
        /// <param name="src">A source value, or null</param>
        /// <typeparam name="T">The enclosed type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Option<T> option<T>(T? src)
            where T : struct
                => Option.from(src);
    }
}