//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Represents a segment register
    /// </summary>
    public readonly struct SegReg
    {
        public SegRegKind Kind {get;}

        public bool IsEmpty => false;
        
        [MethodImpl(Inline)]
        public SegReg(SegRegKind src)
        {
            Kind = src;
        }        

        public static SegReg Empty 
            => new SegReg(SegRegKind.CS);
    }
}