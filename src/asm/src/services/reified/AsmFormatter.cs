//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
        
    public readonly struct AsmFormatter : IAsmFormatter
    {      
        public AsmFormatSpec Config {get;}

        public static IAsmFormatter Default
        {
            [MethodImpl(Inline)]
            get => Create(AsmFormatSpec.Default);
        }

        [MethodImpl(Inline)]
        public static IAsmFormatter Create(AsmFormatSpec config)
            => new AsmFormatter(config);

        [MethodImpl(Inline)]
        AsmFormatter(AsmFormatSpec config)
        {
            Config = config;
        }

        /// <summary>
        /// Formats the assembly function detail
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="fmt">The format configuration</param>
        public string FormatFunction(AsmFunction src)
            => AsmFormat.render(src, Config);

        [MethodImpl(Inline)]        
        public string FormatInstruction(in MemoryAddress @base, in AsmInstructionSummary src)
            => AsmFormat.render(@base, src, Config);

        [MethodImpl(Inline)]        
        public ReadOnlySpan<string> FormatLines(AsmInstructionList src)
            => AsmFormat.lines(src,Config);

        [MethodImpl(Inline)]        
        public ReadOnlySpan<string> FormatLines(AsmFunction src)
            => AsmFormat.lines(src, Config);
    }
}