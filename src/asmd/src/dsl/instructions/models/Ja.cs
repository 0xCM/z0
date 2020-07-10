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
    /// Represents the <see cref='Mnemonic.Ja'/> instruction
    /// </summary>
    public readonly struct Ja : IInstructionModel<Ja>
    {
        public Mnemonic Mnemonic => Mnemonic.Ja;
    }
}