//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.InteropServices;
    
    using static Konst;
    using static As;
    using static Root;

    using NK = NumericKind;

    [ApiHost]
    public readonly struct Variant
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static variant from<T>(T src)
            where T : unmanaged
                => from(store(Cast.to<T,ulong>(src), NumericKinds.kind<T>()));

        [MethodImpl(Inline), Op]
        public static variant convert(variant src, NumericKind dst)
            => from(src.data.WithElement(1,(ulong)dst));

        [MethodImpl(Inline)]
        public static NK kind(variant src)
            => (NK)Vectors.vcell(src.data,1);

        [MethodImpl(Inline)]
        public static DataWidth width(variant src)
            => default;//(ushort)kind(src);

        [MethodImpl(Inline)]
        public static T extract<T>(variant src)
            where T : unmanaged
                => Vectors.vcell(vector<T>(src), 0);

        [MethodImpl(Inline), Op]
        public static variant from(sbyte src)
            => from(store(src, NK.I8));

        [MethodImpl(Inline), Op]
        public static variant from(byte src)
            => from(store(src, NK.U8));

        [MethodImpl(Inline), Op]
        public static variant from(short src)
            => from(store(src, NK.I16));

        [MethodImpl(Inline), Op]
        public static variant from(ushort src)
            => from(store(src, NK.U16));

        [MethodImpl(Inline), Op]
        public static variant from(int src)
            => from(store(src, NK.I32));

        [MethodImpl(Inline), Op]
        public static variant from(uint src)
            => from(store(src, NK.U32));

        [MethodImpl(Inline), Op]
        public static variant from(long src)
            => from(store(src, NK.I64));

        [MethodImpl(Inline), Op]
        public static variant from(ulong src)
            => from(store(src, NK.U64));

        [MethodImpl(Inline), Op]
        public static variant from(float src)
            => from(store(src, NK.F32));

        [MethodImpl(Inline), Op]
        public static variant from(double src)
            => from(store(src, NK.F64));

        [MethodImpl(Inline)]
        static variant from(Vector128<ulong> src)
            => new variant(src);

        [MethodImpl(Inline)]
        static Vector128<T> vector<T>(variant src)
            where T : unmanaged
                => generic<T>(src.data);

        [MethodImpl(Inline)]
        static T cell<T>(variant src, byte index)
            where T : unmanaged
                => Vectors.vcell(vector<T>(src), index);
    
        [MethodImpl(Inline)]
        static Vector128<ulong> store(ulong value, NK kind)
            => Vector128.Create((ulong)value, (ulong)kind);

        [MethodImpl(Inline)]
        static Vector128<ulong> store(long value, NK kind)
            => Vector128.Create((ulong)value, (ulong)kind);

        [MethodImpl(Inline)]
        static Vector128<ulong> store(double value, NK kind)
            => Vector128.Create(value).WithElement(1,(double)kind).AsUInt64();
            
    }
}