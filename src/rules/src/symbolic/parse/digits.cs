//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using C = AsciCode;
    using SQ = SymbolicQuery;
    using SC = SymbolicCalcs;

    partial struct SymbolicParse
    {
        [Op]
        public static int EatWhitespace(ReadOnlySpan<AsciCode> src)
        {
            var count = src.Length;
            var i=0;
            while(i < count)
            {
                if(!SQ.whitespace(skip(src,i)))
                    return i;
                else
                    i++;
            }
            return NotFound;
        }

        [Op]
        public static uint digits(Base10 @base, ReadOnlySpan<char> src, uint offset, Span<byte> dst)
        {
            var i=offset;
            var j=0u;
            var imax = src.Length - 1;
            while(i <= imax)
            {
                ref readonly var c = ref skip(src, i++);
                if(SQ.space(c) && j==0)
                    continue;

                if(SQ.digit(@base, c))
                    seek(dst, j++) = C.d9 - (C)c;
                else
                    break;
            }
            return j;
        }

        [Op]
        public static Outcome parse(Base10 @base, ReadOnlySpan<AsciCode> src, out ushort dst)
        {
            var storage = CharBlock16.Null;
            var buffer = storage.Data;
            SC.convert(src, buffer);
            return ScalarParser.parse(@base, buffer, out dst);
        }

        [Op]
        public static Outcome parse(Base10 @base, ReadOnlySpan<AsciCode> src, ref uint i, out ushort dst)
        {
            dst = default;
            var result = Outcome.Success;
            var input = slice(src,i);
            var length = input.Length;
            var digits = SQ.digits(n16, base10, input);
            if(digits.Length == 0)
                result = (false,"No digits found");
            else
            {
                result = parse(@base, digits, out dst);
                if(result.Ok)
                    i += (uint)digits.Length;
            }
            return result;
        }
    }
}