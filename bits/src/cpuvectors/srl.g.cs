//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;
    
    partial class gbits
    {
         [MethodImpl(Inline)]
        public static Vec128<T> srl<T>(in Vec128<T> lhs, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.srl(in uint8(in lhs), offset));
            else if(typematch<T,sbyte>())
                return generic<T>(Bits.srl(in int8(in lhs), offset));
            if(typeof(T) == typeof(short))
                return generic<T>(Bits.srl(in int16(in lhs), offset));
            else if(typematch<T,ushort>())
                return generic<T>(Bits.srl(in uint16(in lhs), offset));
            if(typeof(T) == typeof(int))
                return generic<T>(Bits.srl(in int32(in lhs), offset));
            else if(typematch<T,uint>()) 
                return generic<T>(Bits.srl(in uint32(in lhs), offset));
            else if(typematch<T,long>())
                return generic<T>(Bits.srl(in int64(lhs), offset));
            else if(typematch<T,ulong>())
                return generic<T>(Bits.srl(in uint64(lhs), offset));
            else
                throw unsupported<T>();
        }

       [MethodImpl(Inline)]
        public static Vec256<T> srl<T>(in Vec256<T> lhs, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.srl(in uint8(in lhs), offset));
            else if(typematch<T,short>())
                return generic<T>(Bits.srl(in int16(in lhs), offset));
            else if(typematch<T,ushort>())
                return generic<T>(Bits.srl(in uint16(in lhs), offset));
            if(typeof(T) == typeof(int))
                return generic<T>(Bits.srl(in int32(in lhs), offset));
            else if(typematch<T,uint>()) 
                return generic<T>(Bits.srl(in uint32(in lhs), offset));
            else if(typematch<T,long>())
                return generic<T>(Bits.srl(in int64(lhs), offset));
            else if(typematch<T,ulong>())
                return generic<T>(Bits.srl(in uint64(lhs), offset));
            else
                throw unsupported<T>();
        }
    }
}