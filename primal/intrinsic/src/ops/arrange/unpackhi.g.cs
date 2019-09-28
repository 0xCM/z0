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
        /// <summary>
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// higher 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the higher 64 bits of the second source vector
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<T> unpackhi<T>(Vec128<T> lhs, Vec128<T> rhs)        
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return generic<T>(dinx.unpackhi(int8(lhs), int8(rhs)));
            else if(typematch<T,byte>())
                return generic<T>(dinx.unpackhi(uint8(lhs), uint8(rhs)));
            else if(typematch<T,short>())
                return generic<T>(dinx.unpackhi(int16(lhs), int16(rhs)));
            else if(typematch<T,ushort>())
                return generic<T>(dinx.unpackhi(uint16(lhs), uint16(rhs)));
            else if(typematch<T,int>())
                return generic<T>(dinx.unpackhi(int32(lhs), int32(rhs)));
            else if(typematch<T,uint>())
                return generic<T>(dinx.unpackhi(uint32(lhs), uint32(rhs)));
            else if(typematch<T,long>())
                return generic<T>(dinx.unpackhi(int64(lhs), int64(rhs)));
            else if(typematch<T,ulong>())
                return generic<T>(dinx.unpackhi(uint64(lhs), uint64(rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(dfp.unpackhi(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.unpackhi(float64(lhs), float64(rhs)));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// __m256i _mm256_unpackhi_epi32 (__m256i a, __m256i b) VPUNPCKHDQ ymm, ymm, ymm/m256
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// higher 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the higher 128 bits of the second source vector
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
       [MethodImpl(Inline)]
        public static Vec256<T> unpackhi<T>(Vec256<T> lhs, Vec256<T> rhs)        
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return generic<T>(dinx.unpackhi(int8(lhs), int8(rhs)));
            else if(typematch<T,byte>())
                return generic<T>(dinx.unpackhi(uint8(lhs), uint8(rhs)));
            else if(typematch<T,short>())
                return generic<T>(dinx.unpackhi(int16(lhs), int16(rhs)));
            else if(typematch<T,ushort>())
                return generic<T>(dinx.unpackhi(uint16(lhs), uint16(rhs)));
            else if(typematch<T,int>())
                return generic<T>(dinx.unpackhi(int32(lhs), int32(rhs)));
            else if(typematch<T,uint>())
                return generic<T>(dinx.unpackhi(uint32(lhs), uint32(rhs)));
            else if(typematch<T,long>())
                return generic<T>(dinx.unpackhi(int64(lhs), int64(rhs)));
            else if(typematch<T,ulong>())
                return generic<T>(dinx.unpackhi(uint64(lhs), uint64(rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(dfp.unpackhi(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.unpackhi(float64(lhs), float64(rhs)));
            else
                throw unsupported<T>();
        }
    }
}