//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Nats;

    partial class PermX
    {
        /// <summary>
        /// Formats a permutation literal as one would hope
        /// </summary>
        /// <param name="src">The literal definition</param>
        public static string Format(this Perm4L src)
            => src.Symbols().ToString();

        /// <summary>
        /// Formats a permutation literal as one would hope
        /// </summary>
        /// <param name="src">The literal definition</param>
        public static string Format(this Perm8L src)
            => src.Symbols().ToString();

        /// <summary>
        /// Formats a permutation literal as one would hope
        /// </summary>
        /// <param name="src">The literal definition</param>
        public static string Format(this Perm16L src)
            => src.Symbols().ToString();

        /// <summary>
        /// Formats the terms of a permutation
        /// </summary>
        /// <param name="terms">The permutation terms</param>
        /// <param name="colwidth">The width of each column</param>
        /// <typeparam name="T">The term type</typeparam>
        public static string FormatAsPerm<T>(this Span<T> terms,  int? colwidth = null)
            => terms.ReadOnly().FormatAsPerm(colwidth);

        /// <summary>
        /// Formats the terms of a permutation
        /// </summary>
        /// <param name="terms">The permutation terms</param>
        /// <param name="colwidth">The width of each column</param>
        /// <typeparam name="T">The term type</typeparam>
        public static string FormatAsPerm<T>(this ReadOnlySpan<T> terms,  int? colwidth = null)
        {
            var line1 = text.factory.Builder();
            var line2 = text.factory.Builder();
            var pad = colwidth ?? 3;
            var leftBoundary = $"{AsciSym.Pipe}";
            var rightBoundary = $"{AsciSym.Pipe}".PadLeft(2);
            
            line1.Append(leftBoundary);
            line2.Append(leftBoundary);
            for(var i=0; i < terms.Length; i++)
            {
                line1.Append($"{i}".PadLeft(pad));
                line2.Append($"{terms[i]}".PadLeft(pad));
            }
            line1.Append(rightBoundary);
            line2.Append(rightBoundary);
            
            return line1.ToString() + text.eol() + line2.ToString();
        }

        /// <summary>
        /// Formats a sequence of successive transpositions (a chain)
        /// </summary>
        /// <param name="src">The transpositions</param>
        [MethodImpl(Inline)]
        public static string Format(this Swap[] src)
            => string.Join(" -> ", src.Map(x => x.Format()));

        public static string FormatBlock(this Perm4L src, bool bracketed = true)
        {
            var bs = BitString.scalar((byte)src);
            var data = bs.Format(false,false,2, AsciSym.Space);
            return bracketed ? text.bracket(data) : data;
        }

        /// <summary>
        /// Formats the value as a permutation map, i.e., [00 01 10 11]: ABCD -> ABDC
        /// </summary>
        /// <param name="src">The permutation spec</param>
        public static string FormatMap(this Perm4L src)
        {
            static char letter(bit x, bit y)
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

            static string letters(BitString bs)
            {
                Span<char> letters = stackalloc char[4];
                int i=0, j=0;
                letters[i++] = letter(bs[j++], bs[j++]);
                letters[i++] = letter(bs[j++], bs[j++]);
                letters[i++] = letter(bs[j++], bs[j++]);            
                letters[i++] = letter(bs[j++], bs[j++]);            
                return new string(letters);
            }

            var bs = BitString.scalar((byte)src);
            var block = src.FormatBlock();
            var domain = $"{Perm4L.A}{Perm4L.B}{Perm4L.C}{Perm4L.D}";
            var codomain = letters(bs);
            var mapping = $"{block}: {domain} -> {codomain}";
            return mapping;
        }             
    }
}