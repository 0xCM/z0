//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;
    using static Root;
    using static IntelSdm;

    using Markers = IntelSdmMarkers;

    partial class IntelSdmProcessor
    {
        static Outcome parse(ReadOnlySpan<char> src, out TableNumber dst)
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
            dst.AppendFormat(string.Format("{0}:", line));
            dst.AppendFormat("{0}{1}", Markers.TableNumber, text.format(src.String));
        }
    }
}