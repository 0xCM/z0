//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Models
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;

    /// <summary>
    /// Defines instruction specification for an opcode
    /// </summary>
    public readonly struct CmdSpec
    {
        /// <summary>
        /// The opcode for which an instruction is specified
        /// </summary>
        public OpCode Code {get;}

        public CmdMode Mode {get;}

    }
}