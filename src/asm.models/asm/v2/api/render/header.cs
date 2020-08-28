//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;

    partial struct AsmRender
    {
        /// <summary>
        /// Formats source bits on a single line intended for emission in the function header
        /// </summary>
        /// <param name="src">The source bits</param>

        [MethodImpl(Inline), Op]
        public static string header(LocatedCode src, OpIdentity id)
            => comment(new ByteSpanProperty(id.ToPropertyName(), src).Format());

        /// <summary>
        /// Formats the function header
        /// </summary>
        /// <param name="src">The source function</param>
        public static ReadOnlySpan<string> header(AsmRoutine src, in AsmFormatSpec? cfg = null)
        {
            var config = cfg ?? AsmFormatSpec.Default;

            var lines = new List<string>();
            lines.Add(comment($"{src.OpSig}, {src.Uri}"));

            if(config.EmitFunctionHeaderEncoding)
                lines.Add(AsmRender.header(src.Code.Encoded, src.OpId));
            else
                lines.Add(comment(src.Code.OpUri.OpId));

            if(config.EmitBaseAddress)
                lines.Add(comment(text.concat("Base", text.spaced(Chars.Eq), src.Code.Address)));

            if(config.EmitCaptureTermCode)
            {
                var cidesc = string.Empty;
                if(config.EmitCaptureTermCode)
                    cidesc += text.concat(nameof(src.TermCode), text.spaced(Chars.Eq), src.TermCode.ToString());

                lines.Add(comment(cidesc));
            }

            if(config.EmitFunctionTimestamp)
                lines.Add(comment(Time.now().ToLexicalString()));

            return lines.ToArray();
        }

    }
}