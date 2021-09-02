//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace types.metadata
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using Z0;

    using static Z0.core;
    using static Z0.Root;

    using generic;

    [ApiHost("types.metadata.factory")]
    public readonly partial struct Factory
    {
        [MethodImpl(Inline), Op]
        public static Scalar scalar(ScalarKind kind, ByteSize storage, BitWidth data)
            => new Scalar(kind,storage,data);

        [MethodImpl(Inline), Op]
        public static Block block(ByteSize size, uint count)
            => new Block(size,count);

        [MethodImpl(Inline)]
        public static Enum<V> @enum<V>(string name, literal<V>[] src)
            => new Enum<V>(name, src);
    }
}
