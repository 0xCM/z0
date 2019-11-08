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
    using static AsIn;

    partial class BitGrid
    {
        /// <summary>
        /// Reads a single bit from a grid given a (row,col) coordinate
        /// </summary>
        /// <param name="src">A reference to the grid source data</param>
        /// <param name="row">The grid row</param>
        /// <param name="col">The grid col</param>
        /// <typeparam name="T">The segment storage type</typeparam>
        [MethodImpl(Inline)]
        public static bit readbit<T>(in GridMoniker moniker, in T src, int row, int col)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return readbit(moniker, in uint8(in src), row, col);
            else if(typeof(T) == typeof(ushort))
                return readbit(moniker,in uint16(in src), row, col);
            else if(typeof(T) == typeof(uint))
                return readbit(moniker,in uint32(in src), row, col);
            else if(typeof(T) == typeof(ulong))
                return readbit(moniker,in uint64(in src), row, col);
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        public static bit readbit<T>(in GridMoniker moniker, in T src, int bitpos)
            where T : unmanaged   
        {
            var segwidth = bitsize<T>();
            var index = bitpos / segwidth;
            var offset = bitpos % segwidth;
            ref readonly var seg = ref skip(in src, index);
            
            return gmath.nonzero(gmath.and(seg, gmath.sll(gmath.one<T>(), offset)));            
        }

        [MethodImpl(Inline)]
        static bit readbit(in GridMoniker moniker, in byte src, int row, int col)    
        {
            const ushort segwidth = 8;
            var bitpos = moniker.ColCount*row + col;
            var index = bitpos / segwidth;
            var offset = bitpos % segwidth;
            
            return (skip(in src, index) & ((byte)(1 << offset))) != 0;        
        }

        [MethodImpl(Inline)]
        static bit readbit(in GridMoniker moniker, in ushort src, int row, int col)    
        {
            const ushort segwidth = 16;
            var bitpos = moniker.ColCount*row + col;
            var index = bitpos / segwidth;
            var offset = bitpos % segwidth;
            
            return (skip(in src, index) & ((ushort)(1 << offset))) != 0;        
        }


        [MethodImpl(Inline)]
        static bit readbit(in GridMoniker moniker, in uint src, int row, int col)    
        {
            const ushort segwidth = 32;
            var bitpos = moniker.ColCount*row + col;
            var index = bitpos / segwidth;
            var offset = bitpos % segwidth;
            
            return (skip(in src, index) & (1u << offset)) != 0;        
        }

        [MethodImpl(Inline)]
        static bit readbit(in GridMoniker moniker, in ulong src, int row, int col)    
        {
            const ushort segwidth = 64;
            var bitpos = moniker.ColCount*row + col;
            var index = bitpos / segwidth;
            var offset = bitpos % segwidth;
            
            return (skip(in src, index) & (1ul << offset)) != 0;        
        }

    }

}