//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Seed;   
    using static Memories;
    using static RecordFields;

    public readonly struct RecordFields
    {
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
                => (short)(Enums.numeric<F,int>(f) >> 16);

        [MethodImpl(Inline)]
        public short Index<F>(F f)
            where F : unmanaged, Enum
                => (short)Enums.numeric<F,int>(f);
 
        [MethodImpl(Inline)]
        public bit Enabled<F>(F f)
            where F : unmanaged, Enum
        {
            var hi = Bits.hi(Enums.numeric<F,uint>(f));                                    
            return !Bits.testbit(hi, 15);
        }            
    }

   public readonly struct RecordFields<F> : IRecordFields<F>
        where F : unmanaged, Enum
    {
        public F[] Literals 
        {        
            [MethodImpl(Inline)]
            get => Service.Literals<F>();
        }

        public string[] Labels 
        {        
            [MethodImpl(Inline)]
            get => Service.Labels<F>();
        }

        [MethodImpl(Inline)]
        public bit Enabled(F f)
            => RecordFields.Service.Enabled(f);

        [MethodImpl(Inline)]
        public short Index(F f)
            => Service.Index(f);

        [MethodImpl(Inline)]
        public short Width(F f)
            => Service.Width(f);
    }
}