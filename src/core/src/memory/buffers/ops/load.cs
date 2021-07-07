//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows;

    using static Windows.Kernel32;

    using static Root;
    using static core;

    unsafe partial struct Buffers
    {
        [Op]
        public static unsafe Span<byte> load(in BinaryCode src, BufferToken dst)
        {
            @check(src,dst);
            var source = span(src.Storage);
            var target = sys.clear(cover(dst.Address.Pointer<byte>(), dst.BufferSize));
            return sys.copy(source,target);
        }

        [Op]
        public static unsafe Span<T> load<T>(ReadOnlySpan<T> src, BufferToken dst)
            where T : unmanaged
        {
            @check(src,dst);
            var target = sys.clear(cover(dst.Address.Pointer<T>(), dst.BufferSize/size<T>()));
            return sys.copy(src,target);
        }
    }
}