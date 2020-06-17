//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    partial class gbits
    {
        /// <summary>
        /// Rotates source cells rightward and deposits the result in a caller-supplied target
        /// </summary>
        /// <param name="src">The leading source cell</param>
        /// <param name="offset">The amount to rotate</param>
        /// <param name="dst">The leading target cell</param>
        /// <param name="count">The cell count</param>
        /// <typeparam name="T">The primal cell type</typeparam>
        [MethodImpl(Inline), Rotr, Closures(UnsignedInts)]
        public static void rotr<T>(in T src, byte offset, ref T dst, int count)
            where T : unmanaged
        {
            for(var i=0; i<count; i++)   
               seek(ref dst, i) =  gbits.rotr(skip(in src, i),offset);
        }

        /// <summary>
        /// Rotates bits in the source rightwards by a specified shift amount
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Rotr, Closures(UnsignedInts)]
        public static T rotr<T>(T src, byte offset)
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
                throw Unsupported.define<T>();
        }           

        /// <summary>
        /// Rotates bits in the source rightwards by a specified shift amount
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The magnitude of the rotation</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Rotr, Closures(UnsignedInts)]
        public static T rotr<T>(T src, byte offset, byte width)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.rotr(uint8(src), offset, width));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.rotr(uint16(src), offset, width));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.rotr(uint32(src), offset, width));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.rotr(uint64(src), offset, width));
            else            
                throw Unsupported.define<T>();
        }           
    }
}