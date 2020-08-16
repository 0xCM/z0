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
    /// Represents the <see cref='Mnemonic.Call'/> instruction
    /// </summary>
    public readonly struct AsmCall
    {
        public Mnemonic Mnemonic => Mnemonic.Call;

        /// <summary>
        /// Creates a sink
        /// </summary>
        /// <param name="receiver"></param>
        [MethodImpl(Inline), Op]
        public static AsmCallSink sink(AsmFxHandler receiver)
            => new AsmCallSink(receiver);
    }
}