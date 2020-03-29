//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static Memories;

    partial class As
    {
        [MethodImpl(Inline)]
        public static ref T generic<S,T>(in S src)
            => ref Unsafe.As<S,T>(ref refs.edit(in src));

        [MethodImpl(Inline)]
        public static T generic<T>(char src)
            => Unsafe.As<char,T>(ref src);                 

        [MethodImpl(Inline)]
        public static T generic<T>(bool src)
            => Unsafe.As<bool,T>(ref src);                 

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T generic<T>(sbyte src)
            => Unsafe.As<sbyte,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(ref sbyte src)
            => ref Unsafe.As<sbyte,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T generic<T>(byte src)
            => Unsafe.As<byte,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(ref byte src)
            => ref Unsafe.As<byte,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T generic<T>(short src)
            => Unsafe.As<short,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(ref short src)
            => ref Unsafe.As<short,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T generic<T>(ushort src)
            => Unsafe.As<ushort,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(ref ushort src)
            => ref Unsafe.As<ushort,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T generic<T>(int src)
            => Unsafe.As<int,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(ref int src)
            => ref Unsafe.As<int,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T generic<T>(uint src)
            => Unsafe.As<uint,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(ref uint src)
            => ref Unsafe.As<uint,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T generic<T>(long src)
            => Unsafe.As<long,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T generic<T>(ulong src)
            => Unsafe.As<ulong,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(ref ulong src)
            => ref Unsafe.As<ulong,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T generic<T>(float src)
            => Unsafe.As<float,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T generic<T>(double src)
            => Unsafe.As<double,T>(ref src);            
    }
}