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
        /// Rotates bits in the source rightwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T rotr<T>(T src, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.rotr(uint8(src), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.rotr(uint16(src), offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.rotr(uint32(src), offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.rotr(uint64(src), offset));
            else            
                throw unsupported<T>();
        }           




    }

}