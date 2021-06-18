//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    using Markers = IntelSdmMarkers;
    using Patterns = IntelSdmPatterns;

    partial struct IntelSdm
    {
        public static Outcome parse(ReadOnlySpan<char> src, out TableNumber dst)
        {
            const char DigitSep = Chars.Dash;
            const char NumberEnd = Chars.Dot;
            dst = TableNumber.Empty;

            var i = Markers.index(src, Markers.TableNumber);
            if(i != NotFound)
            {
                dst = table(slice(src, i + Markers.TableNumber.Length));
                return true;
            }
            return false;
        }

        public static void render(LineNumber line, in TableNumber src, ITextBuffer dst)
        {
            render(line, dst);
            dst.AppendFormat("{0}{1}", Markers.TableNumber, TextTools.format(src.String));
        }
    }
}