//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static Root;

    partial class Widths
    {
        /// <summary>
        /// Transforms a readonly T-cell into an editable T-cell
        /// </summary>
        /// <param name="src">The source cell</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T edit<T>(in T src)
            => ref Unsafe.AsRef(src);

        /// <summary>
        /// Presents an S-cell as a T-cell
        /// </summary>
        /// <param name="src">The source cell</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref T pretend<S,T>(in S src)
            => ref Unsafe.As<S,T>(ref edit(src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint size<T>(T t = default)
            => (uint)Unsafe.SizeOf<T>();

        /// <summary>
        /// Presents a T-references as a <see cref='byte'/> reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref byte u8<T>(in T src)
            => ref pretend<T,byte>(src);

        /// <summary>
        /// Presents a T-reference as a <see cref='ushort'/> reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ushort u16<T>(in T src)
            => ref pretend<T,ushort>(src);

        /// <summary>
        /// Presents a parametric references as a <see cref='uint'/> reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref uint u32<T>(in T src)
            => ref pretend<T,uint>(src);

        /// <summary>
        /// Presents a T-references as a <see cref='ulong'/> reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ulong u64<T>(in T src)
            => ref pretend<T,ulong>(src);

        /// <summary>
        /// Computes the minimum number of bits required to represent the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), EffWidth, Closures(Closure)]
        public static byte effective<T>(T src)
            where T : unmanaged
        {
            if(size<T>() == 1)
                return effective(u8(src));
            else if(size<T>() == 2)
                return effective(u16(src));
            else if(size<T>() == 4)
                return effective(u32(src));
            else if(size<T>() == 8)
                return effective(u64(src));
            else
                throw no<T>();
        }

        /// <summary>
        /// Computes the minimum number of bits required to represent the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), EffWidth]
        public static byte effective(byte src)
            => (byte)(8 - nlz(src));

        /// <summary>
        /// Computes the minimum number of bits required to represent the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), EffWidth]
        public static byte effective(ushort src)
            => (byte)(16 - nlz(src));

        /// <summary>
        /// Computes the minimum number of bits required to represent the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), EffWidth]
        public static byte effective(uint src)
            => (byte)(32 - nlz(src));

        /// <summary>
        /// Computes the minimum number of bits required to represent the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), EffWidth]
        public static byte effective(ulong src)
            => (byte)(64 - nlz(src));

        [MethodImpl(Inline)]
        static int nlz(byte src)
            => (int)(Lzcnt.LeadingZeroCount((uint)src) - 24);

        [MethodImpl(Inline)]
        static int nlz(ushort src)
            => (int)(Lzcnt.LeadingZeroCount((uint)src) - 16);

        [MethodImpl(Inline)]
        static int nlz(uint src)
            => (int)Lzcnt.LeadingZeroCount(src);

        [MethodImpl(Inline)]
        static int nlz(ulong src)
            => (int)Lzcnt.X64.LeadingZeroCount(src);
    }
}