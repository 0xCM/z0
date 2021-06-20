//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public readonly struct DataTypes
    {
        [MethodImpl(Inline), Op]
        public static DataType empty()
            => new DataType(new EmptyDataType());

        [MethodImpl(Inline)]
        public static DataType metadata<T>(T src, uint width = 0)
            where T : IDataType
                => new DataType(src, width);
    }
}