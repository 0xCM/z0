//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IAsmServices
    {
        /// <summary>
        /// Creates an asm formatter with an optional configuration
        /// </summary>
        /// <param name="config">The format configuration, if any</param>
        AsmFormatter Formatter(in AsmFormatConfig? config = null)
            => new AsmFormatter(config);

        /// <summary>
        /// Allocates a caller-disposed asm text writer with a customized format configuration
        /// </summary>
        /// <param name="config">The format configuration</param>
        /// <param name="dst">The target path</param>
        AsmWriter AsmWriter(FilePath dst, in AsmFormatConfig config)
            => new AsmWriter(dst, AsmFormatter.Default);
    }
}