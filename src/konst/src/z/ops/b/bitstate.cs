//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static System.Runtime.CompilerServices.Unsafe;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static bool bool8<T>(T src)
            => As<T,bool>(ref src);

        /// <summary>
        /// Converts a <see cref='bool' /> to a <see cref='BitState' />
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static unsafe BitState bitstate(bool src)
            => (BitState) @byte(src);
    }
}