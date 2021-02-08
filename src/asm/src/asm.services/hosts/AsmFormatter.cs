//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    readonly struct AsmFormatter : IAsmFormatter
    {
        public AsmFormatConfig Config {get;}

        [MethodImpl(Inline)]
        public AsmFormatter(AsmFormatConfig? config)
            => Config = config ?? AsmFormatConfig.Default;

        /// <summary>
        /// Formats the assembly function detail
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="fmt">The format configuration</param>
        public string FormatFunction(AsmRoutine src)
            => AsmRender.format(src, Config);

        [MethodImpl(Inline)]
        public string FormatInstruction(in MemoryAddress @base, in AsmInstructionSummary src)
            => AsmRender.format(@base, src, Config);

        [MethodImpl(Inline)]
        public void Format(in AsmRoutines src, ITextBuffer dst)
            => AsmRender.format(src, Config, dst);

        [MethodImpl(Inline)]
        public void Format(in AsmRoutine src, ITextBuffer dst)
            => AsmRender.format(src, Config, dst);
    }
}