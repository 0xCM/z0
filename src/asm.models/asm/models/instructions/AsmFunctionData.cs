//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;

    using static Konst;

    public struct AsmFunctionData
    {
        /// <summary>
        /// The defining operation uri
        /// </summary>
        public OpUri Uri;

        /// <summary>
        /// The source member signature
        /// </summary>
        public string Sig;
        
        /// <summary>
        /// The defining instructions
        /// </summary>
        public Instruction[] Instructions;

        /// <summary>
        /// The encoded instructions
        /// </summary>
        public MemberCode Encoded;

        /// <summary>
        /// Specifies the reason for capture termination
        /// </summary>
        public ExtractTermCode TermCode;
    }
}