//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmRoutineFormatter : IAsmRoutineFormatter
    {
        public AsmFormatConfig Config {get;}

        [MethodImpl(Inline)]
        public AsmRoutineFormatter(AsmFormatConfig? config = default)
            => Config = AsmFormatConfig.DefaultStreamFormat;

        /// <summary>
        /// Formats the assembly function detail
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="fmt">The format configuration</param>
        public string Format(AsmRoutine src)
            => AsmFormatter.format(src, Config);

        public string Format(in MemoryAddress @base, in AsmInstructionSummary src)
            => AsmFormatter.format(@base, src, Config);

        public void Render(in AsmRoutine src, ITextBuffer dst)
            => AsmFormatter.format(src, Config, dst);
   }
}