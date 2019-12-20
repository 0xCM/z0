//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;


    partial struct BitSpan
    {
        const ushort c0 = (ushort)'0';

        public static string format(in BitSpan src)
        {
            var count = src.Length;      
            Span<char> buffer = stackalloc char[count];
            ref var dst = ref head(buffer);
            for(int i = 0, j=count-1; i < count; i++, j--)
               seek(ref dst, j) = src[i].ToChar();                
            return new string(buffer);
        }

        [MethodImpl(Inline)]
        public string Format()
            => format(this);
    }

}