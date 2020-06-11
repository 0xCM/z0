//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct SegReg
    {
        public static SegReg Empty => new SegReg(SegRegKind.CS);

        public SegRegKind Kind {get;}

        public bool IsEmpty => false;
        
        [MethodImpl(Inline)]
        SegReg(SegRegKind src)
        {
            Kind = src;
        }        
    }
}