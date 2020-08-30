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


    partial struct Variant
    {
        [MethodImpl(Inline), Op]
        public static unsafe variant scalar(Enum src)
        {
            var kind = src.GetType().GetEnumUnderlyingType().NumericKind();
            var converted = (ulong)rebox(src,NumericKind.U64);
            return define(converted, kind);
        }

        [MethodImpl(Inline), Op]
        public static variant define(object src, Type dst)
            => define(src, dst.NumericKind());

        [MethodImpl(Inline), Op]
        public static variant define(object src, NumericKind dst)
        {
            switch(dst)
            {
                case NK.I8:
                    return define((sbyte)src);

                case NK.U8:
                    return define((byte)src);

                case NK.I16:
                    return define((short)src);

                case NK.U16:
                    return define((ushort)src);

                case NK.I32:
                    return define((int)src);

                case NK.U32:
                    return define((uint)src);

                case NK.I64:
                    return define((long)src);

                case NK.U64:
                    return define((ulong)src);

                case NK.F32:
                    return define((float)src);

                case NK.F64:
                    return define((double)src);
            }

            return default;
        }

        [MethodImpl(Inline), Op]
        public static variant define(sbyte src)
            => from(store(src, NK.I8));

        [MethodImpl(Inline), Op]
        public static variant define(byte src)
            => from(store(src, NK.U8));

        [MethodImpl(Inline), Op]
        public static variant define(short src)
            => from(store(src, NK.I16));

        [MethodImpl(Inline), Op]
        public static variant define(ushort src)
            => from(store(src, NK.U16));

        [MethodImpl(Inline), Op]
        public static variant define(int src)
            => from(store(src, NK.I32));

        [MethodImpl(Inline), Op]
        public static variant define(uint src)
            => from(store(src, NK.U32));

        [MethodImpl(Inline), Op]
        public static variant define(long src)
            => from(store(src, NK.I64));

        [MethodImpl(Inline), Op]
        public static variant define(ulong src)
            => from(store(src, NK.U64));

        [MethodImpl(Inline), Op]
        public static variant define(float src)
            => from(store(src, NK.F32));

        [MethodImpl(Inline), Op]
        public static variant define(double src)
            => from(store(src, NK.F64));
    }
}