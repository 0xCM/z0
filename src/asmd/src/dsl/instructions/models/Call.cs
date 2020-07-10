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
    /// Represents the <see cref='Mnemonic.Call'/> instruction
    /// </summary>
    [ApiHost]
    public readonly struct Call : IInstructionModel<Call>
    {
        public Mnemonic Mnemonic => Mnemonic.Call;

        /// <summary>
        /// Creaates a sink
        /// </summary>
        /// <param name="receiver"></param>
        [MethodImpl(Inline), Op]
        public static CallSink sink(InstructionHandler receiver)
            => new CallSink(receiver);
    }
}