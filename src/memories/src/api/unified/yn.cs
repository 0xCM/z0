//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static YeaOrNea;

    partial class Memories
    {
        /// <summary>
        /// Yea or Nea?
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static YeaOrNea yn(bool src) 
            => src ? Y : N;

        /// <summary>
        /// Yea or Nea?
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static YeaOrNea yn(bit src) 
            => src ? Y : N;

        /// <summary>
        /// Yea or Nea?
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static YeaOrNea yn(byte src) 
            => src != 0 ? Y : N;

        /// <summary>
        /// Yea or Nea?
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static YeaOrNea yn(sbyte src) 
            => src != 0 ? Y : N;
    
        /// <summary>
        /// Yea or Nea?
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static YeaOrNea yn(short src) 
            => src != 0 ? Y : N;

        /// <summary>
        /// Yea or Nea?
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static YeaOrNea yn(ushort src) 
            => src != 0 ? Y : N;

        /// <summary>
        /// Yea or Nea?
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static YeaOrNea yn(int src) 
            => src != 0 ? Y : N;

        /// <summary>
        /// Yea or Nea?
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static YeaOrNea yn(uint src) 
            => src != 0 ? Y : N;

        /// <summary>
        /// Yea or Nea?
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static YeaOrNea yn(long src) 
            => src != 0 ? Y : N;

        /// <summary>
        /// Yea or Nea?
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static YeaOrNea yn(ulong src) 
            => src != 0 ? Y : N;

        /// <summary>
        /// Yea or Nea?
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static YeaOrNea yn<E>(E src) 
            where E : unmanaged, Enum
                => src.IsSome() ? Y : N;

    }
}