//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class text
    {
        /// <summary>
        /// Determines the length of a specified <see cref='string'/>
        /// </summary>
        /// <param name="src">The source text</param>
        [MethodImpl(Inline), Op]
        public static int length(string src)
            => src?.Length ?? 0;

        /// <summary>
        /// Computes the number of pointer-identified characters that precede a null-terminator
        /// </summary>
        /// <param name="pSrc">The location of the first character</param>
        [MethodImpl(Inline), Op]
        public static unsafe uint length(char* pSrc)
            => Pointers.length(pSrc);

        /// <summary>
        /// Computes the number of pointer-identified (asci) characters that precede a null-terminator
        /// </summary>
        /// <param name="pSrc">The location of the first character</param>
        [MethodImpl(Inline), Op]
        public static unsafe uint length(byte* pSrc)
        {
            var p = pSrc;
            if(p is null)
                return 0;
            while(*p != Chars.Null)
                p++;
            return (uint)(p - pSrc);
        }
    }
}