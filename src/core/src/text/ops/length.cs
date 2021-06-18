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

    partial struct TextTools
    {
        [MethodImpl(Inline), Op]
        public static uint length(StringAddress src)
        {
            ref var c = ref firstchar(src);
            var counter = 0u;
            while(c != 0)
                c = seek(c, counter++);
            return counter - 1;
        }

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
        {
            var p = pSrc;
            if(p is null)
                return 0;
            while(*p != Chars.Null)
                p++;
            return (uint)(p - pSrc);
        }

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