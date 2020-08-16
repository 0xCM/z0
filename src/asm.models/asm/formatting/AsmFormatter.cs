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
        public AsmFormatSpec Config {get;}

        public static IAsmFormatter Default
        {
            [MethodImpl(Inline)]
            get => new AsmFormatter(null);
        }

        [MethodImpl(Inline)]
        public AsmFormatter(AsmFormatSpec? config)
        {
            Config = config ?? AsmFormatSpec.Default;
        }

        /// <summary>
        /// Formats the assembly function detail
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="fmt">The format configuration</param>
        public string FormatFunction(AsmRoutine src)
            => AsmFormat.render(src, Config);

        [MethodImpl(Inline)]        
        public string FormatInstruction(in MemoryAddress @base, in AsmInstructionSummary src)
            => AsmFormat.render(@base, src, Config);

        [MethodImpl(Inline)]        
        public ReadOnlySpan<string> FormatLines(AsmFxList src)
            => AsmFormat.lines(src,Config);

        [MethodImpl(Inline)]        
        public ReadOnlySpan<string> FormatLines(AsmRoutine src)
            => AsmFormat.lines(src, Config);
    }
}