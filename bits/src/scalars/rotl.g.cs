//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        /// Rotates the source bits leftward by a specified shift amount
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static T rotl<T>(T src, int shift)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.rotl(uint8(src), shift));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.rotl(uint16(src), shift));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.rotl(uint32(src), shift));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.rotl(uint64(src), shift));
            else            
                throw unsupported<T>();
        }           

        /// <summary>
        /// Rotates the source bits leftward by a specified shift amount
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the rotation</param>
        /// <param name="width">The effective bit-width of the source value</param>
        [MethodImpl(Inline)]
        public static T rotl<T>(T src, int shift, int width)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.rotl(uint8(src), shift, width));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.rotl(uint16(src), shift, width));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.rotl(uint32(src), shift, width));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.rotl(uint64(src), shift, width));
            else            
                throw unsupported<T>();
        }           


    }
}