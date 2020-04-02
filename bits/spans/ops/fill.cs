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
        /// Fills a bitspan from a primal source
        /// </summary>
        /// <param name="src">The packed source bits</param>
        [MethodImpl(Inline)]
        public static ref readonly BitSpan fill<T>(T src, in BitSpan dst)
            where T : unmanaged
                => ref fill_u(src,dst);

        [MethodImpl(Inline)]
        static ref readonly BitSpan fill_u<T>(T src, in BitSpan dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return ref fill(uint8(src),dst);
            else if(typeof(T) == typeof(ushort))
                return ref fill(uint16(src),dst);
            else if(typeof(T) == typeof(uint))
                return ref fill(uint32(src),dst);
            else if(typeof(T) == typeof(ulong))
                return ref fill(uint64(src),dst);
            else
                return ref fill_i(src, dst);
        }

        [MethodImpl(Inline)]
        static ref readonly BitSpan fill_i<T>(T src, in BitSpan dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return ref fill(convert<T,byte>(src),dst);
            else if(typeof(T) == typeof(short))
                return ref fill(convert<T,ushort>(src),dst);
            else if(typeof(T) == typeof(int))
                return ref fill(convert<T,uint>(src),dst);
            else if(typeof(T) == typeof(long))
                return ref fill(convert<T,ulong>(src),dst);
            else
                throw Unsupported.define<T>();            
        }

        [MethodImpl(Inline)]
        static ref readonly BitSpan fill(byte src, in BitSpan dst)
        {
            var buffer = Stacks.alloc(w64);
            ref var tmp = ref Stacks.head<byte>(ref buffer);
            ref var target = ref Unsafe.As<bit,uint>(ref head(dst.Bits));

            BitPack.unpack8(src, ref tmp); 
            distribute(in tmp, 0, ref target);
            return ref dst;
        }

        [MethodImpl(Inline)]
        static ref readonly BitSpan fill(ushort src, in BitSpan dst)
        {
            var buffer = Stacks.alloc(w128);
            ref var tmp = ref Stacks.head<byte>(ref buffer);
            ref var target = ref Unsafe.As<bit,uint>(ref head(dst.Bits));

            BitPack.unpack8(src, ref tmp); 
            distribute(in tmp, 0, ref target);
            distribute(in tmp, 1, ref target);
            return ref dst;
        }

        [MethodImpl(Inline)]
        static ref readonly BitSpan fill(uint src, in BitSpan dst)
        {
            ref var tmp = ref head(dst.Bits.Slice(24,8).As<bit,byte>());
            ref var target = ref Unsafe.As<bit,uint>(ref head(dst.Bits));

            BitPack.unpack8(src, ref tmp); 
            distribute(in tmp, 0, ref target);
            distribute(in tmp, 1, ref target);
            distribute(in tmp, 2, ref target);
            distribute(in tmp, 3, ref target);
            return ref dst;
        }

        [MethodImpl(Inline)]
        static ref readonly BitSpan fill(ulong src, in BitSpan dst)
        {
            var buffer = Stacks.alloc(w512);        
            ref var tmp = ref head(dst.Bits.Slice(56,8).As<bit,byte>());
            ref var target = ref Unsafe.As<bit,uint>(ref head(dst.Bits));

            BitPack.unpack8((uint)src, ref tmp); 
            distribute(in tmp, 0, ref target, 0);
            distribute(in tmp, 1, ref target, 1);
            distribute(in tmp, 2, ref target, 2);
            distribute(in tmp, 3, ref target, 3);
            
            BitPack.unpack8((uint)(src >> 32), ref tmp); 
            distribute(in tmp, 0, ref target, 4);
            distribute(in tmp, 1, ref target, 5);
            distribute(in tmp, 2, ref target, 6);
            distribute(in tmp, 3, ref target, 7);
            return ref dst;
        }

        [MethodImpl(Inline)]
        static void distribute(in byte src, int step, ref uint dst)
            => VCore.vstore(dvec.vconvert(w64, in skip(in src, step*8), w256, w32), ref seek(ref dst, step*8));

        [MethodImpl(Inline)]
        static void distribute(in byte src, int srcstep, ref uint dst, int dststep)
            => VCore.vstore(dvec.vconvert(w64, in skip(in src, srcstep*8), w256, w32), ref seek(ref dst, dststep*8));
    }
}