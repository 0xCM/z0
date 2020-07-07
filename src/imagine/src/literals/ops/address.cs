//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct LiteralFields
    {
        [MethodImpl(Inline), Op]
        public static unsafe MemoryAddress address(Type src)
            => pointer(sys.handle(src));

        [MethodImpl(Inline), Op]
        static unsafe void* pointer(IntPtr src)
            => src.ToPointer();
    }
}