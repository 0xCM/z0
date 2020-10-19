//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    partial struct Buffers
    {
        [MethodImpl(Inline)]
        static void @check(in BinaryCode src, BufferToken dst)
        {
            var srcSize = src.Length;
            var dstSize = dst.BufferSize;

            if(srcSize > dstSize)
                sys.@throw(new Exception($"The target buffer of size {dstSize} is insufficient to accomodate the data source of size {srcSize}"));
        }

        [MethodImpl(Inline), Op]
        public static unsafe Span<byte> load(in BinaryCode src, BufferToken dst)
        {
            @check(src,dst);
            var source = z.span(src.Data);
            var target = sys.clear(z.cover(dst.Address.Pointer<byte>(), dst.BufferSize));
            return sys.copy(source,target);
        }

    }
}