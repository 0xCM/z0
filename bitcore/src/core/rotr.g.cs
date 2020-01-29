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
        /// Rotates source cells rightward and deposits the result in a caller-supplied target
        /// </summary>
        /// <param name="src">The leading source cell</param>
        /// <param name="shift">The amount to rotate</param>
        /// <param name="dst">The leading target cell</param>
        /// <param name="count">The cell count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static void rotr<T>(in T src, int shift, ref T dst, int count)
            where T : unmanaged
        {
            for(var i=0; i<count; i++)   
               seek(ref dst, i) =  gbits.rotr(skip(in src, i),shift);
        }

        /// <summary>
        /// Rotates bits in the source rightwards by a specified shift amount
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the rotation</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static T rotr<T>(T src, int shift)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.rotr(uint8(src), shift));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.rotr(uint16(src), shift));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.rotr(uint32(src), shift));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.rotr(uint64(src), shift));
            else            
                throw unsupported<T>();
        }           

        /// <summary>
        /// Rotates bits in the source rightwards by a specified shift amount
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the rotation</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static T rotr<T>(T src, int shift, int width)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.rotr(uint8(src), shift, width));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.rotr(uint16(src), shift, width));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.rotr(uint32(src), shift, width));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.rotr(uint64(src), shift, width));
            else            
                throw unsupported<T>();
        }           

    }

}