//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    using static As;
    

    partial class gbits
    {

        /// <summary>
        /// Rotates each component in the source vector rightwards by a constant offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec128<T> rotr<T>(in Vec128<T> src, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.rotr(in uint8(in src), offset));
            else if(typematch<T,ushort>())
                return generic<T>(Bits.rotr(in uint16(in src), offset));
            else if(typematch<T,uint>()) 
                return generic<T>(Bits.rotr(in uint32(in src), offset));
            else if(typematch<T,ulong>())
                return generic<T>(Bits.rotr(in uint64(in src), offset));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Rotates each component in the source vector rightwards by a constant offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec256<T> rotr<T>(in Vec256<T> src, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.rotr(in uint8(in src), offset));
            else if(typematch<T,ushort>())
                return generic<T>(Bits.rotr(in uint16(in src), offset));
            else if(typematch<T,uint>()) 
                return generic<T>(Bits.rotr(in uint32(in src), offset));
            else if(typematch<T,ulong>())
                return generic<T>(Bits.rotr(in uint64(in src), offset));
            else
                throw unsupported<T>();
        }

    }

}