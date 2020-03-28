//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static root;
    using static As;

    partial class gbits
    {
        /// <summary>
        /// Rotates source cells leftward and deposits the result in a caller-supplied target
        /// </summary>
        /// <param name="src">The leading source cell</param>
        /// <param name="shift">The amount to rotate</param>
        /// <param name="dst">The leading target cell</param>
        /// <param name="count">The cell count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static void rotl<T>(in T src, int shift, ref T dst, int count)
            where T : unmanaged
        {
            for(var i=0; i<count; i++)   
               seek(ref dst, i) =  gbits.rotl(skip(in src, i),shift);
        }
 
        /// <summary>
        /// Rotates the source bits leftward by a specified shift amount
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the rotation</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
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
                throw Unsupported.define<T>();
        }           

        /// <summary>
        /// Rotates the source bits leftward by a specified shift amount
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the rotation</param>
        /// <param name="width">The effective bit-width of the source value</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
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
                throw Unsupported.define<T>();
        }           
    }
}