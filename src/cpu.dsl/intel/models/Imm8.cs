//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Vdsl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Intel
    {
        public struct Imm8
        {
            byte Data;

            [MethodImpl(Inline)]
            public Imm8(byte src)
            {
                Data = src;
            }

            public bit this[int i]
            {
                [MethodImpl(Inline)]
                get => bit.test(Data,(byte)i);
            }

            public static implicit operator Imm8(byte src)
                => new Imm8(src);
        }
    }
}