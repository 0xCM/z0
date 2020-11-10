//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.DataModels, true)]
    public readonly partial struct DataModels
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DataModel<K> define<K>(utf8 name, K kind)
            where K : unmanaged
                => new DataModel<K>(name, kind);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DataModel<K> define<K>(string name, K kind)
            where K : unmanaged
                => new DataModel<K>(name, kind);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DataRef<T> reference<T>(in T src)
            where T : struct
                => new DataRef<T>(typeof(T).MetadataToken);
    }
}