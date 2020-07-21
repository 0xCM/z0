//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static Konst;
    using static z;

    using NK = NumericKind;

    [ApiHost]
    public readonly partial struct Variant
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static variant from<T>(T src)
            where T : unmanaged
                => from(store(z.convert<T,ulong>(src), nk<T>()));

        [MethodImpl(Inline), Op]
        public static variant define(ulong src, NumericKind dst)
            => from(store(src, dst));

        [MethodImpl(Inline), Op]
        public static variant convert(variant src, NumericKind dst)
            => from(src.data.WithElement(1,(ulong)dst));

        [MethodImpl(Inline)]
        public static NK kind(variant src)
            => (NK)vcell(src.data,1);

        [MethodImpl(Inline)]
        public static DataWidth width(variant src)
            => (DataWidth)src.DataWidth;

        [MethodImpl(Inline)]
        public static T extract<T>(variant src)
            where T : unmanaged
                => vcell(vector<T>(src), 0);

        [MethodImpl(Inline)]
        static variant from(Vector128<ulong> src)
            => new variant(src);

        [MethodImpl(Inline)]
        static Vector128<T> vector<T>(variant src)
            where T : unmanaged
                => generic<T>(src.data);
    
        [MethodImpl(Inline)]
        static Vector128<ulong> store(ulong value, NK kind)
            => vparts((ulong)value, (ulong)kind);

        [MethodImpl(Inline)]
        static Vector128<ulong> store(long value, NK kind)
            => vparts((ulong)value, (ulong)kind);

        [MethodImpl(Inline)]
        static Vector128<ulong> store(double value, NK kind)
            => Vector128.Create(value).WithElement(1, (double)kind).AsUInt64();           
    }
}