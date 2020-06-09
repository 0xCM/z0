//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Seed;

    partial class Control
    {                
        /// <summary>
        /// Reads a generic numeric value from a generic enum. 
        /// </summary>
        /// <param name="e">The enum value to reinterpret</param>
        /// <typeparam name="E">The enum source type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe V numeric<E,V>(E e)
            where E : unmanaged, Enum
            where V : unmanaged
                => Unsafe.Read<V>((V*)(&e));

        /// <summary>
        /// Reimagines a boolean value as a numeric value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static unsafe byte numeric(bool src)
            => *((byte*)(&src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe byte u8<T>(T src)
            where T : unmanaged             
                => *((byte*)(&src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe sbyte i8<T>(T src)
            where T : unmanaged             
                => *((sbyte*)(&src));

        [MethodImpl(Inline), Op, Closures(Seed.Numeric16x32x64)]
        public static unsafe ushort u16<T>(T src)
            where T : unmanaged             
                => *((ushort*)(&src));

        [MethodImpl(Inline), Op, Closures(Seed.Numeric16x32x64)]
        public static unsafe short i16<T>(T src)
            where T : unmanaged             
                => *((short*)(&src));

        [MethodImpl(Inline), Op, Closures(Seed.Numeric32x64)]
        public static unsafe uint u32<T>(T src)
            where T : unmanaged             
                => *((uint*)(&src));

        [MethodImpl(Inline), Op, Closures(Seed.Numeric32x64)]
        public static unsafe int i32<T>(T src)
            where T : unmanaged             
                => *((int*)(&src));

        [MethodImpl(Inline), Op, Closures(Seed.Numeric64)]
        public static unsafe ulong u64<T>(T src)
            where T : unmanaged             
                => *((ulong*)(&src));

        [MethodImpl(Inline), Op, Closures(Seed.Numeric64)]
        public static unsafe long i64<T>(T src)
            where T : unmanaged             
                => *((long*)(&src));

        [MethodImpl(Inline), Op, Closures(Seed.Numeric32x64)]
        public static unsafe float f32<T>(T src)
            where T : unmanaged             
                => *((float*)(&src));

        [MethodImpl(Inline), Op, Closures(Seed.Numeric64)]
        public static unsafe double f64<T>(T src)
            where T : unmanaged             
                => *((double*)(&src));

        [MethodImpl(Inline)]
        public static unsafe decimal f128<T>(T src)
            where T : unmanaged             
                => *((decimal*)(&src));
    }
}