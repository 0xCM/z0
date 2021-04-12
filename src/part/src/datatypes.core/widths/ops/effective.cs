//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static Part;
    using static memory;

    partial class Widths
    {
        /// <summary>
        /// Computes the minimum number of bits required to represent the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), EffWidth, Closures(Closure)]
        public static int effective<T>(T src)
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