//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmFunctionData
    {
        /// <summary>
        /// The defining operation uri
        /// </summary>
        public readonly OpUri Uri;

        /// <summary>
        /// The source member signature
        /// </summary>
        public readonly string Sig;
        
        /// <summary>
        /// The defining instructions
        /// </summary>
        public readonly Instruction[] Instructions;

        /// <summary>
        /// The encoded instructions
        /// </summary>
        public readonly MemberCode Encoded;

        /// <summary>
        /// Specifies the reason for capture termination
        /// </summary>
        public readonly ExtractTermCode TermCode;
    }
}