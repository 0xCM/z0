//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly partial struct DataTypes
    {
        public static DataTypeFormatter<T> formatter<T>()
            where T : struct, IDataType<T>
                => default;
    }
}
