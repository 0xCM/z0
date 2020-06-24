//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;   
    using static Root;

    public readonly struct RecordFields
    {
        public static RecordFields Service => default;

        [MethodImpl(Inline)]
        public static RecordFields<F> Create<F>()
            where F : unmanaged, Enum
                => default;

        [MethodImpl(Inline)]
        public F[] Literals<F>()
            where F : unmanaged, Enum            
                => Enums.literals<F>();

        [MethodImpl(Inline)]
        public string[] Labels<F>()
            where F : unmanaged, Enum
                => Literals<F>().Map(f => f.ToString());

        [MethodImpl(Inline)]
        public short Width<F>(F f)
            where F : unmanaged, Enum
                => (short)(scalar<F,int>(f) >> 16);

        [MethodImpl(Inline)]
        public short Index<F>(F f)
            where F : unmanaged, Enum
                => (short)scalar<F,int>(f);

    }
}