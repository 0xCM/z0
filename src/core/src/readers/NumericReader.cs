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

    [ApiHost]
    public ref struct NumericReader
    {
        ReadOnlySpan<byte> Source;

        public static NumericReader create(ReadOnlySpan<byte> src)
            => new NumericReader(src);

        [MethodImpl(Inline)]
        NumericReader(ReadOnlySpan<byte> src)
        {
            Source = src;
            Pos = 0;
            Max = (uint)src.Length - 1;
        }

        uint Pos;

        uint Max;

        ref readonly byte First8u
        {
            [MethodImpl(Inline)]
            get => ref skip(Source,0);
        }

        public bool Next(out byte dst)
        {
            var result = true;
            if(Pos <= Max)
                dst = seek(First8u,Pos++);
            else
            {
                result = false;
                dst = 0xFF;
            }
            return result;
        }
   }
}