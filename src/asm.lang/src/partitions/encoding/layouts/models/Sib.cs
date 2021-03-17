//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct LayoutComponents
    {
        public readonly struct Sib : ISib
        {
            public uint3 Base {get;}

            public uint3 Index {get;}

            public uint2 Scale {get;}

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => Base == 0 && Index == 0 && Scale == 0;
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
}