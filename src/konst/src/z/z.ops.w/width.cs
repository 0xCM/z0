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
        /// Computes the type width of a parametrically-identified type
        /// </summary>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static DataWidth width<W>(W w = default)
            where W : unmanaged, IDataWidth<W>
                => w.DataWidth;
    }
}