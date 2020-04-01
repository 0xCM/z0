//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;
    using static As;
    

    partial struct BitSpan
    {
        /// <summary>
        /// Creates a bitspan from a primal source
        /// </summary>
        /// <param name="src">The packed source bits</param>
        [MethodImpl(Inline)]
        public static BitSpan from<T>(T src)
            where T : unmanaged
                => from_u(src);

        /// <summary>
        /// Creates a bitspan from a primal source, or portion thereof
        /// </summary>
        /// <param name="src">The packed source bits</param>
        /// <param name="maxbits">The maximum number of bits to draw from the source</param>
        [MethodImpl(Inline)]
        public static BitSpan from<T>(T src, int maxbits)
            where T : unmanaged
        {
            var dst = from(src);
            return (dst.Length > maxbits && maxbits != 0)
                ? load(dst.bits.Slice(0, maxbits))  
                : dst;
        }

        [MethodImpl(Inline)]
        static BitSpan from_u<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return from(uint8(src));
            else if(typeof(T) == typeof(ushort))
                return from(uint16(src));
            else if(typeof(T) == typeof(uint))
                return from(uint32(src));
            else if(typeof(T) == typeof(ulong))
                return from(uint64(src));
            else
                return from_i(src);
        }

        [MethodImpl(Inline)]
        static BitSpan from_i<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return from(convert<T,byte>(src));
            else if(typeof(T) == typeof(short))
                return from(convert<T,ushort>(src));
            else if(typeof(T) == typeof(int))
                return from(convert<T,uint>(src));
            else if(typeof(T) == typeof(long))
                return from(convert<T,ulong>(src));
            else
                throw Unsupported.define<T>();            
        }

        [MethodImpl(Inline)]
        static BitSpan from(byte src)
        {
            var buffer = Stacks.alloc(w64);
            ref var tmp = ref Stacks.head<byte>(ref buffer);
            
            var storage = Stacks.alloc(w256);
            ref var target = ref Stacks.head<uint>(ref storage);

            BitPack.unpack8(src, ref tmp); 
            distribute(in tmp, 0, ref target);
            return load(Stacks.span<uint>(ref storage).As<bit>());
        }

        [MethodImpl(Inline)]
        static BitSpan from(ushort src)
        {
            var buffer = Stacks.alloc(w128);
            ref var tmp = ref Stacks.head<byte>(ref buffer);

            var storage = Stacks.alloc(w512);
            ref var target = ref Stacks.head<uint>(ref storage);            
            
            BitPack.unpack8(src, ref tmp); 
            distribute(in tmp, 0, ref target);
            distribute(in tmp, 1, ref target);
            return load(Stacks.span<uint>(ref storage).As<bit>());
        }

        [MethodImpl(Inline)]
        static BitSpan from(uint src)
        {
            var buffer = Stacks.alloc(w256);
            ref var tmp = ref Stacks.head<byte>(ref buffer);

            var storage = Stacks.alloc(w1024);
            ref var target = ref Stacks.head<uint>(ref storage);            
            
            BitPack.unpack8(src, ref tmp); 
            distribute(in tmp, 0, ref target);
            distribute(in tmp, 1, ref target);
            distribute(in tmp, 2, ref target);
            distribute(in tmp, 3, ref target);
            return load(Stacks.span<uint>(ref storage).As<bit>());
        }

        [MethodImpl(Inline)]
        static BitSpan from(ulong src)
        {
            var buffer = Stacks.alloc(w512);
            ref var tmp = ref Stacks.head<byte>(ref buffer);

            Span<uint> storage = new uint[64];
            ref var target = ref head(storage);

            BitPack.unpack8(src, ref tmp); 
            distribute(in tmp, 0, ref target);
            distribute(in tmp, 1, ref target);
            distribute(in tmp, 2, ref target);
            distribute(in tmp, 3, ref target);
            distribute(in tmp, 4, ref target);
            distribute(in tmp, 5, ref target);
            distribute(in tmp, 6, ref target);
            distribute(in tmp, 7, ref target);
            return load(storage.As<bit>());
        }    
    }
}