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

    using C = AsciCharCode;

    partial struct TextTools
    {
        /// <summary>
        /// Advances two cells unconditionally
        /// </summary>
        /// <param name="src"></param>
        /// <param name="i"></param>
        /// <param name="a0"></param>
        /// <param name="a1"></param>
        [MethodImpl(Inline), Op]
        public static uint next(ReadOnlySpan<byte> src, ref uint i, out byte a0, out byte a1)
        {
            a0 = skip(src,i++);
            a1 = skip(src,i++);
            return 2;
        }

        [MethodImpl(Inline), Op]
        public static int next(ReadOnlySpan<byte> src, uint offset, C a0)
        {
            var i = 0;
            while(i < src.Length)
            {
                if((C)skip(src,i++) == a0)
                    return (int)i;
            }
            return NotFound;
        }

        [MethodImpl(Inline), Op]
        public static int next(ReadOnlySpan<byte> src, uint offset, C a0, C a1)
        {
            var i=0;
            var max = src.Length - 1;
            while(i < max)
            {
                ref readonly var b0 = ref skip(src,i);
                ref readonly var b1 = ref skip(src,i+1);
                if((C)b0 == a0 && (C)b1 == a1)
                    return i;

                i++;
            }
            return NotFound;
        }
    }
}