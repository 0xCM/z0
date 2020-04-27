//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public static class AsmDecoder
    {
        /// <summary>
        /// Creates a function decoder
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="format">The format configuration</param>
        [MethodImpl(Inline)]
        public static IAsmFunctionDecoder FunctionDecoder(AsmFormatConfig format = null)
            => AsmFunctionDecoder.Create(format ?? AsmFormatConfig.New);

        /// <summary>
        /// Creates an instruction decoder
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="format">The format configuration</param>
        [MethodImpl(Inline)]
        public static IAsmInstructionDecoder InstructionDecoder(AsmFormatConfig format = null)
            => AsmInstructionDecoder.Create(format ?? AsmFormatConfig.New);
    }
}