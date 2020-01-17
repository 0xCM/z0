//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    using static As;
    using static AsIn;

    partial class gbits
    {
        /// <summary>
        /// Creates a bitview over a source value
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static BitView<T> view<T>(ref T src)
            where T: unmanaged
                => new BitView<T>(ref src);

        /// <summary>
        /// Computes the maximum number of bits that can be represented by the type
        /// </summary>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), PrimalClosures(PrimalKind.All)]
        public static int width<T>()
            where T : unmanaged
                => Unsafe.SizeOf<T>()*8;

        /// <summary>
        /// Computes the minimal number of bits required to represent the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.All)]
        public static int width<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Bits.width(uint8(src));
            else if(typeof(T) == typeof(ushort))
                return Bits.width(uint16(src));
            else if(typeof(T) == typeof(uint))
                return Bits.width(uint32(src));
            else if(typeof(T) == typeof(ulong))
                return Bits.width(uint64(src));
            else            
                throw unsupported<T>();
        }           
    }
}