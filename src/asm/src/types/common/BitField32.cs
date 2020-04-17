//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Vectors;

    public struct BitField32
    {
        Vector256<byte> data;

        public static BitField32<E> Create<E>()
            where E : unmanaged, Enum
                => default(BitField32<E>);
        
        public bit this[int index]
        {
            [MethodImpl(Inline)]
            get => vcell(data,index) == 1;

            [MethodImpl(Inline)]
            set => data = vcell((byte)value, index, data);
        }

        public string Format()
            => data.Format();
    }
    
    public struct BitField32<E>
        where E : unmanaged, Enum
    {
        BitField32 data;

        [MethodImpl(Inline)]
        public int ComponentIndex(E literal)
            => (int)math.log2(Enums.u32(literal));

        public bit this[E literal]
        {
            [MethodImpl(Inline)]
            get => data[ComponentIndex(literal)];
            [MethodImpl(Inline)]
            set => data[ComponentIndex(literal)] = value;
        }

        public string Format()
            => data.Format();
    }
}