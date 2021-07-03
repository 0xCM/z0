//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using static Root;

    [ApiHost]
    public readonly struct DataConverters
    {
        [MethodImpl(Inline), Op]
        public static DataConverter adapt(IDataConverter converter)
            => new DataConverter(converter);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static DataConverter<C> adapt<C>(IDataConverter<C> converter)
            => new DataConverter<C>(converter);
    }
}