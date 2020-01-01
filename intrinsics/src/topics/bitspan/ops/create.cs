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

    partial struct BitSpan
    {
        /// <summary>
        /// Creates a bitspan from a primal source
        /// </summary>
        /// <param name="src">The packed source bits</param>
        [MethodImpl(Inline)]
        public static BitSpan create<T>(T src)
            where T : unmanaged
                => create_u(src);

        [MethodImpl(Inline)]
        static BitSpan create_u<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return create(uint8(src));
            else if(typeof(T) == typeof(ushort))
                return create(uint16(src));
            else if(typeof(T) == typeof(uint))
                return create(uint32(src));
            else if(typeof(T) == typeof(ulong))
                return create(uint64(src));
            else
                return create_i(src);
        }

        [MethodImpl(Inline)]
        static BitSpan create_i<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return create(convert<T,byte>(src));
            else if(typeof(T) == typeof(short))
                return create(convert<T,ushort>(src));
            else if(typeof(T) == typeof(int))
                return create(convert<T,uint>(src));
            else if(typeof(T) == typeof(long))
                return create(convert<T,ulong>(src));
            else
                throw unsupported<T>();            
        }

        [MethodImpl(Inline)]
        static BitSpan create(byte src)
        {
            var buffer = Stacks.alloc(n64);
            ref var tmp = ref Stacks.head<byte>(ref buffer);
            
            var storage = Stacks.alloc(n256);
            ref var target = ref Stacks.head<uint>(ref storage);

            BitPack.unpack8x8(src, ref tmp); 
            distribute(in tmp, 0, ref target);
            return load(Stacks.span<uint>(ref storage).As<bit>());
        }

        [MethodImpl(Inline)]
        static BitSpan create(ushort src)
        {
            var buffer = Stacks.alloc(n128);
            ref var tmp = ref Stacks.head<byte>(ref buffer);

            var storage = Stacks.alloc(n512);
            ref var target = ref Stacks.head<uint>(ref storage);            
            
            BitPack.unpack16x8(src, ref tmp); 
            distribute(in tmp, 0, ref target);
            distribute(in tmp, 1, ref target);
            return load(Stacks.span<uint>(ref storage).As<bit>());
        }

        [MethodImpl(Inline)]
        static BitSpan create(uint src)
        {
            var buffer = Stacks.alloc(n256);
            ref var tmp = ref Stacks.head<byte>(ref buffer);

            var storage = Stacks.alloc(n1024);
            ref var target = ref Stacks.head<uint>(ref storage);            
            
            BitPack.unpack32x8(src, ref tmp); 
            distribute(in tmp, 0, ref target);
            distribute(in tmp, 1, ref target);
            distribute(in tmp, 2, ref target);
            distribute(in tmp, 3, ref target);
            return load(Stacks.span<uint>(ref storage).As<bit>());
        }

        [MethodImpl(Inline)]
        static BitSpan create(ulong src)
        {
            var buffer = Stacks.alloc(n512);
            ref var tmp = ref Stacks.head<byte>(ref buffer);

            Span<uint> storage = new uint[64];
            ref var target = ref head(storage);

            BitPack.unpack64x8(src, ref tmp); 
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