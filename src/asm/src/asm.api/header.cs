//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static memory;
    using static AsmDocParts;

    partial struct asm
    {
        /// <summary>
        /// Formats the function header
        /// </summary>
        /// <param name="src">The source function</param>
        [Op]
        public static ReadOnlySpan<string> header(AsmRoutine src)
        {
            var dst = span<string>(8);
            const string Separator = "; " + RP.PageBreak160;
            var count = lines(new BlockHeader(Separator, src.Code.Uri, src.DisplaySig, src.Code, src.TermCode), dst);
            return slice(dst, 0, count);
        }
    }
}