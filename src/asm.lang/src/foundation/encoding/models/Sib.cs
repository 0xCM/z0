//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Sib
    {
        readonly uint8T Data;

        public uint3 Base
        {
            [MethodImpl(Inline)]
            get => Bits.segment(Data, 0, 2);
        }

        public uint3 Index
        {
            [MethodImpl(Inline)]
            get => Bits.segment(Data, 3, 5);
        }

        public uint2 Scale
        {
            [MethodImpl(Inline)]
            get => Bits.segment(Data, 6, 7);
        }

        public MemoryScale ScaleFactor
        {
            [MethodImpl(Inline)]
            get => Pow2.pow8u(Scale);
        }

        public bool IsZero
        {
            [MethodImpl(Inline)]
            get => Data.Equals(0);
        }

        public bool IsNonZero
        {
            [MethodImpl(Inline)]
            get => !IsZero;
        }

        public string Format()
            => AsmRender.format(this);


        public override string ToString()
            => Format();

        public static Sib Empty
            => default;
    }
}