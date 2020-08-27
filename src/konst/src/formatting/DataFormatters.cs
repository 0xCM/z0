//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;

    public readonly struct DataFormatters
    {
        [MethodImpl(Inline)]
        public static ValueFormatter<F,T> from<F,T>(IValueFormatter<F,T> src)
            where F : unmanaged, Enum
            where T : struct
                => new ValueFormatter<F,T>(src);
    }
}