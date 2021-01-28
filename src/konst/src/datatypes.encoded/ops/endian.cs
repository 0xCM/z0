//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Encoded
    {
        [MethodImpl(Inline)]
        public static EndianKind<T> endian<T>()
            where T : struct, IEndianKind<T>
                => default;

        [MethodImpl(Inline)]
        public static EndianKind id<T>(EndianKind<T> src)
            where T : struct, IEndianKind<T>
                => src.Id;
    }
}