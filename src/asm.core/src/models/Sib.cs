//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    // SIB[Scale[6,7] | Index[3,5] | Base[0,2]]
    public struct Sib
    {
        byte Data;

        public uint3 Base()
            => Bits.segment(Data, 0, 2);

        public uint3 Index()
            => Bits.segment(Data, 3, 5);

        public uint2 Scale()
            => Bits.segment(Data, 6, 7);

        public MemoryScale ScaleFactor
        {
            [MethodImpl(Inline)]
            get => Pow2.pow8u(Scale());
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data.Equals(0);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public static Sib Empty
            => default;
    }
}