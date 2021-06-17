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

    partial struct IntelSdm
    {
        /// <summary>
        /// Counts the number of placeholders in a specified line segment
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static byte PlaceholderCount(ReadOnlySpan<char> src)
        {
            var counter = z8;
            for(var i=0; i<src.Length - 1; i+=2)
            {
                ref readonly var c0 = ref skip(src, i);
                ref readonly var c1 = ref skip(src, i + 1);
                if(placeholder(c0,c1))
                    counter++;
                else
                    break;

            }
            return counter;
        }

        /// <summary>
        /// Tests whether the specified input sequence is of the form ' .' or '. '
        /// </summary>
        /// <param name="c0">The first character in the placeholder sequence</param>
        /// <param name="c1">The second character in the placeholder sequence</param>
        [MethodImpl(Inline), Op]
        public static bool placeholder(char c0, char c1)
            => (c0 == Placeholder.Space && c1 == Placeholder.Dot) || (c0 == Placeholder.Dot && c1 == Placeholder.Space);

        /// <summary>
        /// Finds the beginning of the toc entry placeholders
        /// </summary>
        /// <param name="src">The data source</param>
        public static int placeholder(ReadOnlySpan<char> src)
        {
            var i = TextTools.index(src," . . . .");
            var j = TextTools.index(src,". . . . ");
            if(i != NotFound && j != NotFound)
                return min(i,j);
            else
                return NotFound;
        }

        public static void render(Placeholder src, ITextBuffer dst)
        {
            for(var i=0; i<src.Count; i++)
                dst.AppendFormat("{0}{1}", Placeholder.Space, Placeholder.Dot);
        }

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<Placeholder> placeholders(uint count)
            => slice(recover<Placeholder>(Placeholders), 0, count);

        static ReadOnlySpan<byte> Placeholders
            => new byte[]{
                0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,
                17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,
                33,34,35,36,37,38,29,40,41,42,43,44,45,46,47,48,
                49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68
                };

    }
}
