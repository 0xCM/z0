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
    using SB = SpannedBits;

    partial class BitSpans
    {
        /// <summary>
        /// Fills a bitspan from a primal source
        /// </summary>
        /// <param name="src">The packed source bits</param>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly BitSpan fill<T>(T src, in BitSpan dst)
            where T : unmanaged
                => ref fill_u(src,dst);

        [MethodImpl(Inline)]
        static ref readonly BitSpan fill_u<T>(T src, in BitSpan dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return ref SB.fill(uint8(src),dst);
            else if(typeof(T) == typeof(ushort))
                return ref SB.fill(uint16(src),dst);
            else if(typeof(T) == typeof(uint))
                return ref SB.fill(uint32(src),dst);
            else if(typeof(T) == typeof(ulong))
                return ref SB.fill(uint64(src),dst);
            else
                return ref fill_i(src, dst);
        }

        [MethodImpl(Inline)]
        static ref readonly BitSpan fill_i<T>(T src, in BitSpan dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return ref SB.fill(convert<T,byte>(src),dst);
            else if(typeof(T) == typeof(short))
                return ref SB.fill(convert<T,ushort>(src),dst);
            else if(typeof(T) == typeof(int))
                return ref SB.fill(convert<T,uint>(src),dst);
            else if(typeof(T) == typeof(long))
                return ref SB.fill(convert<T,ulong>(src),dst);
            else
                throw Unsupported.define<T>();            
        }
    }
}