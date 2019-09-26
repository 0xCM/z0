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
    
    using static zfunc;

    using static As;

    partial class ginx
    {
        public static Span128<T> sub<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : struct
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(ginx.sub(ginx.lddqu128(in lhs.Block(block)), ginx.lddqu128(in rhs.Block(block))), ref dst.Block(block));
            return dst;
        }

        public static Span256<T> sub<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : struct
        {            
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(ginx.sub(ginx.lddqu256(in lhs.Block(block)), ginx.lddqu256(in rhs.Block(block))), ref dst.Block(block));
            return dst;
        }


        public static Span128<T> add<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : struct
        {
            if(typematch<T,sbyte>())
                dinx.add(int8(lhs), int8(rhs), int8(dst));
            else if(typematch<T,byte>())
                dinx.add(uint8(lhs), uint8(rhs), uint8(dst));                    
            else if(typematch<T,short>())
                dinx.add(int16(lhs), int16(rhs), int16(dst));
            else if(typematch<T,ushort>())
                dinx.add(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typematch<T,int>())
                dinx.add(int32(lhs), int32(rhs), int32(dst));
            else if(typematch<T,uint>())
                dinx.add(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typematch<T,long>())
                dinx.add(int64(lhs), int64(rhs), int64(dst));
            else if(typematch<T,ulong>())
                dinx.add(uint64(lhs), uint64(rhs), uint64(dst));
            else if(typematch<T,float>())
                dfp.add(float32(lhs), float32(rhs), float32(dst));
            else if(typematch<T,double>())
                dfp.add(float64(lhs), float64(rhs), float64(dst));
            else    
                throw unsupported<T>();
            return dst;        
        }

        public static Span256<T> add<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : struct
        {
            if(typematch<T,sbyte>())
                dinx.add(int8(lhs), int8(rhs), int8(dst));
            else if(typematch<T,byte>())
                dinx.add(uint8(lhs), uint8(rhs), uint8(dst));                    
            else if(typematch<T,short>())
                dinx.add(int16(lhs), int16(rhs), int16(dst));
            else if(typematch<T,ushort>())
                dinx.add(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typematch<T,int>())
                dinx.add(int32(lhs), int32(rhs), int32(dst));
            else if(typematch<T,uint>())
                dinx.add(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typematch<T,long>())
                dinx.add(int64(lhs), int64(rhs), int64(dst));
            else if(typematch<T,ulong>())
                dinx.add(uint64(lhs), uint64(rhs), uint64(dst));
            else if(typematch<T,float>())
                dfp.add(float32(lhs), float32(rhs), float32(dst));
            else if(typematch<T,double>())
                dfp.add(float64(lhs), float64(rhs), float64(dst));
            else    
                throw unsupported<T>();
            return dst;        
        } 


    }

}