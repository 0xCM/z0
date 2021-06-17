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

    partial class IntelSdmProcessor
    {
        static Outcome parse(ReadOnlySpan<char> src, out SectionNumber dst)
        {
            dst = SectionNumber.Empty;
            if(!IsSectionNumber(src))
                return false;

            var digits = text.split(src.ToString(), Chars.Dot).View;
            var count = digits.Length;
            if(count == 0)
                return false;
            switch(count)
            {
                case 1:
                    ushort.TryParse(skip(digits, 0), out dst.A);
                    break;

                case 2:
                    ushort.TryParse(skip(digits, 0), out dst.A);
                    ushort.TryParse(skip(digits, 1), out dst.B);
                break;

                case 3:
                    ushort.TryParse(skip(digits, 0), out dst.A);
                    ushort.TryParse(skip(digits, 1), out dst.B);
                    ushort.TryParse(skip(digits, 2), out dst.C);
                break;

                case 4:
                    ushort.TryParse(skip(digits, 0), out dst.A);
                    ushort.TryParse(skip(digits, 1), out dst.B);
                    ushort.TryParse(skip(digits, 2), out dst.C);
                    ushort.TryParse(skip(digits, 3), out dst.D);
                break;

                default:
                    return false;

            }
            return true;
        }

        static bool IsSectionNumber(ReadOnlySpan<char> src)
        {
            var count = src.Length;
            if(count == 0)
                return false;

            for(var i=0; i<count; i++)
            {
                ref readonly var c = ref skip(src,i);

                if(SymbolicQuery.digit(base10,c))
                    continue;

                if(c == Chars.Dot)
                    continue;

                return false;
            }
            return true;
        }

        static void render(LineNumber line, in SectionNumber src, ITextBuffer dst)
        {
            dst.AppendFormat(string.Format("{0}:", line));
            render(src, dst);
        }

        static void render(in SectionNumber src, ITextBuffer dst)
        {
            var count = src.Count;
            if(count >= 1)
                dst.Append(src.A.ToString());
            if(count >= 2)
                dst.Append(string.Format(".{0}",src.B));
            if(count >= 3)
                dst.Append(string.Format(".{0}",src.C));
            if(count >= 4)
                dst.Append(string.Format(".{0}",src.D));
        }
    }
}