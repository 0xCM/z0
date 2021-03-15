//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;

    partial class Permute
    {
        /// <summary>
        /// Enumerates all permutation map format strings on 4 symbols
        /// </summary>
        public static Index<Paired<Perm4L,string>> symbols(N4 n)
            => (from perm in ClrEnums.literals<Perm4L>()
                    where !VPerm.test(perm)
                    let maps = root.paired(perm, FormatBlock(perm))
                    orderby maps.Right descending
                    select maps).Array();

        [Op]
        public static string FormatBlock(Perm4L src, bool bracketed = true)
        {
            var bs = BitString.scalar((byte)src);
            var data = bs.Format(false, false,2, Chars.Space);
            return bracketed ? text.bracket(data) : data;
        }

        [MethodImpl(Inline), Op]
        public static char letter(N4 n, bit x, bit y)
        {
            if(x && y)
                return 'D';
            else if(!x && !y)
                return 'A';
            else if(x && !y)
                return 'B';
            else
                return 'C';
        }

        [MethodImpl(Inline), Op]
        public static Span<char> letters(N4 n, BitString src, Span<char> dst)
        {
            int i=0, j=0;
            dst[i++] = letter(n4, src[j++], src[j++]);
            dst[i++] = letter(n4, src[j++], src[j++]);
            dst[i++] = letter(n4, src[j++], src[j++]);
            dst[i++] = letter(n4, src[j++], src[j++]);
            return dst;
        }

        /// <summary>
        /// Formats the value as a permutation map, i.e., [00 01 10 11]: ABCD -> ABDC
        /// </summary>
        /// <param name="src">The permutation spec</param>
        public static string FormatMap(Perm4L src)
        {
            var n = n4;
            Span<char> buffer = stackalloc char[n];
            var bs = BitString.scalar((byte)src);
            var block = FormatBlock(src);
            var domain = $"{Perm4L.A}{Perm4L.B}{Perm4L.C}{Perm4L.D}";
            var codomain = new string(letters(n,bs,buffer));
            var mapping = $"{block}: {domain} -> {codomain}";
            return mapping;
        }
    }
}