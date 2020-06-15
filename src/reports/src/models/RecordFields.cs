//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;   
    using static Control;

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
                => Enums.valarray<F>();

        [MethodImpl(Inline)]
        public string[] Labels<F>()
            where F : unmanaged, Enum
            => Literals<F>().Map(f => f.ToString());

        [MethodImpl(Inline)]
        public short Width<F>(F f)
            where F : unmanaged, Enum
                => (short)(tVal<F,int>(f) >> 16);

        [MethodImpl(Inline)]
        public short Index<F>(F f)
            where F : unmanaged, Enum
                => (short)tVal<F,int>(f);
 

        // [MethodImpl(Inline), Hi]
        // static uint hi(uint src)
        //     => (ushort)(src >> 16); 

        // [MethodImpl(Inline)]
        // public bool Enabled<F>(F f)
        //     where F : unmanaged, Enum
        // {
            
        //     var upper = hi(tVal<F,uint>(f));                                    
        //     return !Bits.testbit(upper, 15);
        // }            
    }
}