//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;


    public struct Sib
    {
        byte data;

        [MethodImpl(Inline)]
        public static Sib Init(byte src)        
            => new Sib(src);

        [MethodImpl(Inline)]
        Sib(byte src)
        {
            data = src;
        }

        public byte Scale
        {
            [MethodImpl(Inline)]
            get => Bits.slice(data, 6, 2);
            
            [MethodImpl(Inline)]
            set => data = Bits.copy(value, 6, 2, data);
        }

        public byte Index
        {
            [MethodImpl(Inline)]
            get => Bits.slice(data, 3, 3);
            
            [MethodImpl(Inline)]
            set => data = Bits.copy(value, 3, 5, data);
        }

        public byte Base
        {
            [MethodImpl(Inline)]
            get => Bits.slice(data, 0, 3);
            
            [MethodImpl(Inline)]
            set => data = Bits.copy(value, 0, 2, data);
        }
    }
}