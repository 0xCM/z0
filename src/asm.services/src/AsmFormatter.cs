//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmFormatter : IAsmFormatter
    {
        public AsmFormatConfig Config {get;}

        public static IAsmFormatter Default
        {
            [MethodImpl(Inline)]
            get => new AsmFormatter(null);
        }

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
        public string FormatInstruction(in MemoryAddress @base, in AsmFxSummary src)
            => AsmRender.format(@base, src, Config);

        [MethodImpl(Inline)]
        public ReadOnlySpan<string> FormatLines(AsmFxList src)
            => AsmRender.lines(src, Config);

        [MethodImpl(Inline)]
        public ReadOnlySpan<string> FormatLines(AsmRoutine src)
            => AsmRender.lines(src, Config);
    }
}