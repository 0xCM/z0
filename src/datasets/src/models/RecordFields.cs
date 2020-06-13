//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;   

    public readonly struct RecordFields
    {
        public const int WidthOffset = 16;
        
        public static RecordFields Service => default(RecordFields);

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
                => (short)(Enums.scalar<F,int>(f) >> 16);

        [MethodImpl(Inline)]
        public short Index<F>(F f)
            where F : unmanaged, Enum
                => (short)Enums.scalar<F,int>(f);
 
        [MethodImpl(Inline)]
        public bit Enabled<F>(F f)
            where F : unmanaged, Enum
        {
            var hi = Bits.hi(Enums.scalar<F,uint>(f));                                    
            return !Bits.testbit(hi, 15);
        }            
    }
}