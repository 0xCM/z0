//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static As;
    using static zfunc;

    partial class gbits
    {
        [MethodImpl(Inline)]
        public static Vec128<T> vor<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return generic<T>(Bits.vor(in int8(in lhs), in int8(in rhs)));
            else if(typematch<T,byte>())
                return generic<T>(Bits.vor(in uint8(in lhs), in uint8(in rhs)));
            else if(typematch<T,short>())
                return generic<T>(Bits.vor(in int16(in lhs), in int16(in rhs)));
            else if(typematch<T,ushort>())
                return generic<T>(Bits.vor(in uint16(in lhs), in uint16(in rhs)));
            else if(typematch<T,int>())
                return generic<T>(Bits.vor(in int32(in lhs), in int32(in rhs)));
            else if(typematch<T,uint>())
                return generic<T>(Bits.vor(in uint32(in lhs), in uint32(in rhs)));
            else if(typematch<T,long>())
                return generic<T>(Bits.vor(in int64(in lhs), in int64(in rhs)));
            else if(typematch<T,ulong>())
                return generic<T>(Bits.vor(in uint64(in lhs), in uint64(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(Bits.vor(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(Bits.or(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }



        [MethodImpl(Inline)]
        public static Vec256<T> vor<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return generic<T>(Bits.vor(in int8(in lhs), in int8(in rhs)));
            else if(typematch<T,byte>())
                return generic<T>(Bits.vor(in uint8(in lhs), in uint8(in rhs)));
            else if(typematch<T,short>())
                return generic<T>(Bits.vor(in int16(in lhs), in int16(in rhs)));
            else if(typematch<T,ushort>())
                return generic<T>(Bits.vor(in uint16(in lhs), in uint16(in rhs)));
            else if(typematch<T,int>())
                return generic<T>(Bits.vor(in int32(in lhs), in int32(in rhs)));
            else if(typematch<T,uint>())
                return generic<T>(Bits.vor(in uint32(in lhs), in uint32(in rhs)));
            else if(typematch<T,long>())
                return generic<T>(Bits.vor(in int64(in lhs), in int64(in rhs)));
            else if(typematch<T,ulong>())
                return generic<T>(Bits.vor(in uint64(in lhs), in uint64(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(Bits.vor(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(Bits.vor(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }        
    }
}