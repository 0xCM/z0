//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    public readonly struct ByteCode
    {
        public static T execute<T>(string name, ReadOnlySpan<byte> code, T a, T b)
            where T : unmanaged
        {
            var f = BinaryOpFactory.create<T>(name,code);
            return f(a,b);
        }

        public static void execute<T>(string name, ReadOnlySpan<byte> code, uint offset, ReadOnlySpan<T> a, ReadOnlySpan<T> b, Span<T> dst)
            where T : unmanaged
        {
            seek(dst,offset) = execute(name, code, skip(a,offset), skip(b,offset));
        }
    }
}