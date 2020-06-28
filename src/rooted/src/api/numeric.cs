//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Roots
    {                
        [MethodImpl(Inline), Op]
        public static unsafe sbyte i8(bool on)
            => *((sbyte*)(&on));

        [MethodImpl(Inline), Op]
        public static unsafe byte u8(bool on)
            => *((byte*)(&on));

        [MethodImpl(Inline), Op]
        public static unsafe short i16(bool on)
            => *((sbyte*)(&on));

        [MethodImpl(Inline), Op]
        public static unsafe ushort u16(bool on)
            => *((byte*)(&on));

        [MethodImpl(Inline), Op]
        public static unsafe int i32(bool on)
            => *((sbyte*)(&on));

        [MethodImpl(Inline), Op]
        public static unsafe uint u32(bool on)
            => *((byte*)(&on));

        [MethodImpl(Inline), Op]
        public static unsafe ulong u64(bool on)
            => *((byte*)(&on));
        
        [MethodImpl(Inline), Op]
        public static unsafe long i64(bool on)
            => *((sbyte*)(&on));

        [MethodImpl(Inline), Op]
        public static unsafe float f32(bool on)
            => *((sbyte*)(&on));

        [MethodImpl(Inline), Op]
        public static unsafe double f64(bool on)
            => *((sbyte*)(&on));

        [MethodImpl(Inline), Op]
        public static unsafe decimal f128(bool on)
            => *((sbyte*)(&on));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe byte u8<T>(T src)
            where T : unmanaged             
                => *((byte*)(&src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe sbyte i8<T>(T src)
            where T : unmanaged             
                => *((sbyte*)(&src));

        [MethodImpl(Inline), Op, Closures(Numeric16x32x64)]
        public static unsafe ushort u16<T>(T src)
            where T : unmanaged             
                => *((ushort*)(&src));

        [MethodImpl(Inline), Op, Closures(Numeric16x32x64)]
        public static unsafe short i16<T>(T src)
            where T : unmanaged             
                => *((short*)(&src));

        [MethodImpl(Inline), Op, Closures(Numeric32x64)]
        public static unsafe uint u32<T>(T src)
            where T : unmanaged             
                => *((uint*)(&src));

        [MethodImpl(Inline), Op, Closures(Numeric32x64)]
        public static unsafe int i32<T>(T src)
            where T : unmanaged             
                => *((int*)(&src));

        [MethodImpl(Inline), Op, Closures(Numeric64)]
        public static unsafe ulong u64<T>(T src)
            where T : unmanaged             
                => *((ulong*)(&src));

        [MethodImpl(Inline), Op, Closures(Numeric64)]
        public static unsafe long i64<T>(T src)
            where T : unmanaged             
                => *((long*)(&src));

        [MethodImpl(Inline), Op, Closures(Numeric32x64)]
        public static unsafe float f32<T>(T src)
            where T : unmanaged             
                => *((float*)(&src));

        [MethodImpl(Inline), Op, Closures(Numeric64)]
        public static unsafe double f64<T>(T src)
            where T : unmanaged             
                => *((double*)(&src));

        [MethodImpl(Inline)]
        public static unsafe decimal f128<T>(T src)
            where T : unmanaged             
                => *((decimal*)(&src));
    }
}