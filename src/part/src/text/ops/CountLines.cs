//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsciControlCode;
    using static core;

    using CC = AsciControlCode;

    partial class text
    {
        [MethodImpl(Inline), Op]
        public static bool eol(byte a0, byte a1)
            => (CC)a0 == CR || (CC)a1 == LF;

        [MethodImpl(Inline), Op]
        public static uint CountLines(ReadOnlySpan<byte> src)
        {
            var size = src.Length;
            var counter = 0u;
            for(var pos=0u; pos<size- 1; pos++)
            {
                ref readonly var a0 = ref skip(src, pos);
                ref readonly var a1 = ref skip(src, pos + 1);
                if(eol(a0,a1))
                    counter++;
            }
            return counter;
        }
    }
}