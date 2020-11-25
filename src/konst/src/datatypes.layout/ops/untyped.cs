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

    partial struct DataLayouts
    {
        [Op, Closures(Closure)]
        public static DataLayout untyped<T>(DataLayout<T> src)
            where T : unmanaged
                => new DataLayout(src.Id, src.Storage.Map(x => untyped(x)));

        [Op, Closures(Closure)]
        public static DataLayout untyped<T,R>(DataLayout<T,R> src)
            where T : unmanaged
            where R : unmanaged
                => new DataLayout(src.Id, src.Storage.Map(x => untyped(x)));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static LayoutPartition untyped<T>(in LayoutPartition<T> src)
            where T : unmanaged
                => new LayoutPartition(src.Id, src.Left, src.Right);


        [MethodImpl(Inline), Op, Closures(Closure)]
        public static LayoutPartition untyped<T,R>(in LayoutPartition<T,R> src)
            where T : unmanaged
            where R : unmanaged
                => new LayoutPartition(src.Id, @as<R,ulong>(src.Left), @as<R,ulong>(src.Right));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static LayoutIdentity untyped<T>(in LayoutIdentity<T> src)
            where T : unmanaged
                => new LayoutIdentity(src.Index, @as<T,uint>(src.Kind));
    }
}