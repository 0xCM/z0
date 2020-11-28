//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct DataTypeFormatter<T> : IDataTypeFormatter<T>
        where T : struct, IDataType<T>
    {
        [MethodImpl(Inline)]
        public Span<byte> Format(in T src)
            => memory.bytes(src);
    }
}