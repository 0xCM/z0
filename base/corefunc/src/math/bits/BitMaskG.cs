//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static zfunc;
    using static As;
    using static AsIn;

    /// <summary>
    /// Defines generic bitmask functions that parameterize those defined in <see cref='BitMask'/>
    /// </summary>
    public static partial class BitMaskG
    {
        /// <summary>
        /// Sets an identified bit to a supplied value
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The bit position</param>
        /// <param name="value">The value to be applied</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T set<T>(ref T src, byte pos, in Bit value)            
            where T : unmanaged
        {
            if(value)
                enable(ref src, pos);
            else
                disable(ref src, pos);
            return ref src;
        }

        /// <summary>
        /// Enables a bit in the target if it is enabled in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="srcpos">The source bit position</param>
        /// <param name="dst">The target value</param>
        /// <param name="dstpos">The target bit position</param>
        [MethodImpl(Inline)]
        public static ref T setif<T>(in T src, int srcpos, ref T dst, int dstpos)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                BitMask.setif(in int8(in src), srcpos, ref int8(ref dst), dstpos);
            else if(typematch<T,byte>())
                BitMask.setif(in uint8(in src), srcpos, ref uint8(ref dst), dstpos);
            else if(typematch<T,short>())
                BitMask.setif(in int16(in src), srcpos, ref int16(ref dst), dstpos);
            else if(typeof(T) == typeof(ushort))
                BitMask.setif(in uint16(in src), srcpos, ref uint16(ref dst), dstpos);
            else if(typematch<T,int>())
                BitMask.setif(in int32(in src), srcpos, ref int32(ref dst), dstpos);
            else if(typeof(T) == typeof(uint))
                BitMask.setif(in uint32(in src), srcpos, ref uint32(ref dst), dstpos);
            else if(typematch<T,long>())
                BitMask.setif(in int64(in src), srcpos, ref int64(ref dst), dstpos);
            else if(typeof(T) == typeof(ulong))
                BitMask.setif(in uint64(in src), srcpos, ref uint64(ref dst), dstpos);
            else if(typeof(T) == typeof(float))
                BitMask.setif(in float32(in src), srcpos, ref float32(ref dst), dstpos);
            else if(typeof(T) == typeof(double))
                BitMask.setif(in float64(in src), srcpos, ref float64(ref dst), dstpos);
            else
                throw unsupported<T>();
                
            return ref dst;                            
        }



    }
}