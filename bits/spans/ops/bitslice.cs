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
    using static P2K;
    using static Nats;
 
    partial struct BitSpan
    {
        /// <summary>
        /// Materializes a bitspan segment as a scalar value
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="offset">The source index to begin extraction</param>
        /// <param name="count">The number of source bits that contribute to the extract</param>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline),Op,NumericClosures(NumericKind.UnsignedInts)]
        public static T bitslice<T>(in BitSpan src, int offset, int count)
            where T : unmanaged
        {            
            Span<bit> dst = new bit[bitsize<T>()];
            var len = math.min(count, src.Length - offset);
            Cells.copy(src.Bits, offset, len, dst);
            return BitPack.pack<T>(dst);
        }

        /// <summary>
        /// Materializes a bitspan segment as a scalar value
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline),Op,NumericClosures(NumericKind.UnsignedInts)]
        public static T bitslice<T>(in BitSpan src, int offset)
            where T : unmanaged
        {            
            Span<bit> dst = new bit[bitsize<T>()];
            var len = math.min(dst.Length, src.Length - offset);
            Cells.copy(src.Bits, offset, len, dst);
            return BitPack.pack<T>(dst);
        }

        /// <summary>
        /// Materializes a bitspan segment as a scalar value
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline),Op,NumericClosures(NumericKind.UnsignedInts)]
        public static T bitslice<T>(in BitSpan src)
            where T : unmanaged
        {            
            Span<bit> dst = new bit[bitsize<T>()];
            var len = math.min(dst.Length, src.Length);
            Cells.copy(src.Bits, 0, len, dst);
            return BitPack.pack<T>(dst);
        }

        [MethodImpl(Inline)]
        static T bitslice_u<T>(in BitSpan src, int offset, int count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(bitslice_8u(src, offset, count));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(bitslice_16u(src, offset, count));
            else if(typeof(T) == typeof(uint))
                return generic<T>(bitslice_32u(src, offset, count));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(bitslice_64u(src, offset, count));
            else    
                return bitslice_i<T>(src,offset,count);
        }
                    
        [MethodImpl(Inline)]
        static T bitslice_i<T>(in BitSpan src, int offset, int count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(bitslice_8i(src, offset, count));
            else if(typeof(T) == typeof(short))
                return generic<T>(bitslice_16i(src, offset,count));
            else if(typeof(T) == typeof(int))
                return generic<T>(bitslice_32i(src, offset,count));
            else if(typeof(T) == typeof(long))
                return generic<T>(bitslice_64i(src, offset, count));
            else
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        static sbyte bitslice_8i(in BitSpan src, int offset, int count)
        {
            var buffer = Stacks.alloc(p2x6);
            var unpacked = Stacks.span<bit>(ref buffer);   
            ref var dst = ref Stacks.head<bit>(ref buffer);            
            memory.copy(in skip(src.Bits, offset), ref dst, count);        
            return BitPack.pack(unpacked,z8i);
        }

        [MethodImpl(Inline)]
        static byte bitslice_8u(in BitSpan src, int offset, int count)
        {
            var buffer = Stacks.alloc(p2x6);
            var unpacked = Stacks.span<bit>(ref buffer);   
            ref var dst = ref Stacks.head<bit>(ref buffer);            
            memory.copy(in skip(src.Bits, offset), ref dst, count);        
            return BitPack.pack(unpacked,z8);
        }

        [MethodImpl(Inline)]
        static short bitslice_16i(in BitSpan src, int offset, int count)
        {
            var buffer = Stacks.alloc(p2x7);
            var unpacked = Stacks.span<bit>(ref buffer);   
            ref var dst = ref Stacks.head<bit>(ref buffer);            
            memory.copy(in skip(src.Bits, offset), ref dst, count);        
            return BitPack.pack(unpacked,z16i);
        }

        [MethodImpl(Inline)]
        static ushort bitslice_16u(in BitSpan src, int offset, int count)
        {
            var buffer = Stacks.alloc(p2x7);
            var unpacked = Stacks.span<bit>(ref buffer);   
            ref var dst = ref Stacks.head<bit>(ref buffer);            
            memory.copy(in skip(src.Bits, offset), ref dst, count);        
            return BitPack.pack(unpacked,z16);
        }

        [MethodImpl(Inline)]
        static int bitslice_32i(in BitSpan src, int offset, int count)
        {
            var buffer = Stacks.alloc(p2x8);
            var unpacked = Stacks.span<bit>(ref buffer);   
            ref var dst = ref Stacks.head<bit>(ref buffer);            
            memory.copy(in skip(src.Bits, offset), ref dst, count);        
            return BitPack.pack(unpacked,z32i);
        }

        [MethodImpl(Inline)]
        static uint bitslice_32u(in BitSpan src, int offset, int count)
        {
            var buffer = Stacks.alloc(p2x8);
            var unpacked = Stacks.span<bit>(ref buffer);
            var take = math.min(src.Bits.Length -offset, count);
            src.Bits.Slice(offset,take).CopyTo(unpacked);
            return BitPack.pack(unpacked, z32);
        }

        [MethodImpl(Inline)]
        static long bitslice_64i(in BitSpan src, int offset, int count)
        {
            var buffer = Stacks.alloc(p2x9);
            var unpacked = Stacks.span<bit>(ref buffer);   
            ref var dst = ref Stacks.head<bit>(ref buffer);            
            memory.copy(in skip(src.Bits, offset), ref dst, count);        
            return BitPack.pack(unpacked, z64i);
        }

        [MethodImpl(Inline)]
        static ulong bitslice_64u(in BitSpan src, int offset, int count)
        {
            var buffer = Stacks.alloc(p2x9);
            var unpacked = Stacks.span<bit>(ref buffer);   
            ref var dst = ref Stacks.head<bit>(ref buffer);            
            memory.copy(in skip(src.Bits, offset), ref dst, count);        
            return BitPack.pack(unpacked, z64);
        }
    }
}