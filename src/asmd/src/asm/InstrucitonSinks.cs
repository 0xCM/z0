//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct InstructionSinks
    {
        [MethodImpl(Inline)]
        public static InstructionSink define(Mnemonic mnemonic, InstructionHandler handler)
            => new InstructionSink(mnemonic, handler);
    }
}