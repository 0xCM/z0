//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct SegmentPrefix : INullity
    {
        public readonly Register Register;

        [MethodImpl(Inline)]
        public SegmentPrefix(Register src)
            => Register = src;

        public bool IsEmpty 
            => Register == Register.None;

        public static bool test(Instruction inxs, int index)     
            => !asm.segprefix(inxs, index).IsEmpty;

        public static SegmentPrefix Empty 
            => new SegmentPrefix(Register.None);   
    }
}