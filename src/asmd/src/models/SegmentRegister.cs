//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct SegReg
    {
        public static SegReg Empty => new SegReg(SegRegKind.None);

        public SegRegKind Kind {get;}

        public bool IsEmpty 
        {
            [MethodImpl(Inline)]
            get => Kind == SegRegKind.None;
        }
        
        [MethodImpl(Inline)]
        SegReg(SegRegKind src)
        {
            Kind = src;
        }        
    }
}