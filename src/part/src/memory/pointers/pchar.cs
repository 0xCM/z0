//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    unsafe partial struct Pointers
    {
        /// <summary>
        /// Creates a representation over a specified pointer
        /// </summary>
        /// <param name="pSrc">The source pointer</param>
        [MethodImpl(Inline), Op]
        public static PChar pchar(ushort* pSrc)
            => new PChar((char*)pSrc);

        /// <summary>
        /// Creates a representation over a specified pointer
        /// </summary>
        /// <param name="pSrc">The source pointer</param>
        [MethodImpl(Inline), Op]
        public static PChar pchar(void* pSrc)
            => new PChar((char*)pSrc);

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
    }
}