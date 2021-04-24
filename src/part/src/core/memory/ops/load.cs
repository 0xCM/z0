//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct memory
    {
        [Op]
        public static unsafe Span<byte> load(in BinaryCode src, BufferToken dst)
        {
            @check(src,dst);
            var source = span(src.Storage);
            var target = sys.clear(cover(dst.Address.Pointer<byte>(), dst.BufferSize));
            return sys.copy(source,target);
        }

        [MethodImpl(Inline)]
        static void @check(in BinaryCode src, BufferToken dst)
        {
            var srcSize = src.Length;
            var dstSize = dst.BufferSize;
            if(src.Length > dst.BufferSize)
                sys.@throw("The buffer is too small");
        }
    }
}