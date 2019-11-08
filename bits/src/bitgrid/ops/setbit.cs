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

    partial class BitGrid
    {
        /// <summary>
        /// Sets the state of an a coordinate-identified grid bit
        /// </summary>
        /// <param name="src">A reference to the grid storage</param>
        /// <param name="M">The number of rows in the grid</param>
        /// <param name="N">The number of columns in the grid</param>
        /// <param name="row">The row of interest</param>
        /// <param name="col">The column of interest</param>
        /// <param name="state">The source state</param>
        /// <typeparam name="T">The grid storage segment type</typeparam>
        [MethodImpl(Inline)]
        public static void setbit<T>(in GridMoniker moniker, int row, int col, bit state, ref T dst)    
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                setbit(moniker, row, col, state,ref uint8(ref dst));
            else if(typeof(T) == typeof(ushort))
                setbit(moniker, row, col, state, ref uint16(ref dst));
            else if(typeof(T) == typeof(uint))
                setbit(moniker, row, col, state, ref uint32(ref dst));
            else if(typeof(T) == typeof(ulong))
                setbit(moniker, row, col, state, ref uint64(ref dst));
            else            
                throw unsupported<T>();
        }

        /// <summary>
        /// Sets the state of a grid bit identified by its linear position
        /// </summary>
        /// <param name="src">A reference to the grid storage</param>
        /// <param name="M">The number of rows in the grid</param>
        /// <param name="N">The number of columns in the grid</param>
        /// <param name="bitpos">The 0-based linear bit index</param>
        /// <param name="state">The source state</param>
        /// <typeparam name="T">The grid storage segment type</typeparam>
        [MethodImpl(Inline)]
        public static void setbit<T>(in GridMoniker moniker, int bitpos, bit state, ref T dst)    
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                setbit(moniker, bitpos, state,ref uint8(ref dst));
            else if(typeof(T) == typeof(ushort))
                setbit(moniker, bitpos, state, ref uint16(ref dst));
            else if(typeof(T) == typeof(uint))
                setbit(moniker, bitpos, state, ref uint32(ref dst));
            else if(typeof(T) == typeof(ulong))
                setbit(moniker, bitpos, state, ref uint64(ref dst));
            else            
                throw unsupported<T>();
        }
        
        [MethodImpl(Inline)]
        static void setbit(in GridMoniker moniker, int row, int col, bit state, ref byte dst)    
        {
            const ushort segwidth = 8;

            var bitpos = moniker.ColCount*row + col;
            var index = bitpos / segwidth;
            var offset = bitpos % segwidth;
            ref var segment = ref seek(ref dst, index);
            
            BitMask.set(ref segment, (byte)offset, state); 
        }

        [MethodImpl(Inline)]
        static void setbit(in GridMoniker moniker, int row, int col, bit state, ref ushort dst)    
        {
            const ushort segwidth = 16;
            var bitpos = moniker.ColCount*row + col;
            var index = bitpos / segwidth;
            var offset = bitpos % segwidth;
            ref var segment = ref seek(ref dst, index);
            
            BitMask.set(ref segment, (byte)offset, state); 
        }

        [MethodImpl(Inline)]
        static void setbit(in GridMoniker moniker, int row, int col, bit state, ref uint dst)    
        {
            const ushort segwidth = 32;
            var bitpos = moniker.ColCount*row + col;
            var index = bitpos / segwidth;
            var offset = bitpos % segwidth;
            ref var segment = ref seek(ref dst, index);
            
            BitMask.set(ref segment, (byte)offset, state); 
        }

        [MethodImpl(Inline)]
        static void setbit(in GridMoniker moniker, int row, int col, bit state, ref ulong dst)    
        {
            const ushort segwidth = 64;
            var bitpos = moniker.ColCount*row + col;
            var index = bitpos / segwidth;
            var offset = bitpos % segwidth;
            ref var segment = ref seek(ref dst, index);
            
            BitMask.set(ref segment, (byte)offset, state); 
        }

        [MethodImpl(Inline)]
        static void setbit(in GridMoniker moniker, int bitpos, bit state, ref byte dst)    
        {
            const ushort segwidth = 8;            
            var index = bitpos / segwidth;
            var offset = bitpos % segwidth;
            ref var segment = ref seek(ref dst, index);
            
            BitMask.set(ref segment, (byte)offset, state); 
        }

        [MethodImpl(Inline)]
        static void setbit(in GridMoniker moniker, int bitpos, bit state, ref ushort dst)    
        {
            const ushort segwidth = 16;            
            var index = bitpos / segwidth;
            var offset = bitpos % segwidth;
            ref var segment = ref seek(ref dst, index);
            
            BitMask.set(ref segment, (byte)offset, state); 
        }

        [MethodImpl(Inline)]
        static void setbit(in GridMoniker moniker, int bitpos, bit state, ref uint dst)    
        {
            const ushort segwidth = 32;            
            var index = bitpos / segwidth;
            var offset = bitpos % segwidth;
            ref var segment = ref seek(ref dst, index);
            
            BitMask.set(ref segment, (byte)offset, state); 
        }

        [MethodImpl(Inline)]
        static void setbit(in GridMoniker moniker, int bitpos, bit state, ref ulong dst)    
        {
            const ushort segwidth = 64;            
            var index = bitpos / segwidth;
            var offset = bitpos % segwidth;
            ref var segment = ref seek(ref dst, index);
            
            BitMask.set(ref segment, (byte)offset, state); 
        }

    }

}