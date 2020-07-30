//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    /// <summary>
    /// Represents the <see cref='Mnemonic.Jmp'/> instruction
    /// </summary>
    public readonly struct Jmp
    {
        public Mnemonic Mnemonic => Mnemonic.Jmp;

        [MethodImpl(Inline), Op]
        public static JmpSink sink(InstructionHandler receiver)
            => new JmpSink(receiver);
    }
}