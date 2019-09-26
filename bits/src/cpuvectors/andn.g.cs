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
    using static AsIn;
    
    partial class gbits
    {

        /// <summary>
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
         [MethodImpl(Inline)]
        public static Vector128<T> andn<T>(Vector128<T> lhs, Vector128<T> rhs)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return generic<T>(Bits.andn(int8(lhs), int8(rhs)));
            else if(typematch<T,byte>())
                return generic<T>(Bits.andn(uint8(lhs), uint8(rhs)));
            else if(typematch<T,short>())
                return generic<T>(Bits.andn(int16(lhs), int16(rhs)));
            else if(typematch<T,ushort>())
                return generic<T>(Bits.andn(uint16(lhs), uint16(rhs)));
            else if(typematch<T,int>())
                return generic<T>(Bits.andn(int32(lhs), int32(rhs)));
            else if(typematch<T,uint>())
                return generic<T>(Bits.andn(uint32(lhs), uint32(rhs)));
            else if(typematch<T,long>())
                return generic<T>(Bits.andn(int64(lhs), int64(rhs)));
            else if(typematch<T,ulong>())
                return generic<T>(Bits.andn(uint64(lhs), uint64(rhs)));
            else if(typematch<T,float>())
                return generic<T>(Bits.andn(float32(lhs), float32(rhs)));
            else if(typematch<T,double>())
                return generic<T>(Bits.andn(float64(lhs), float64(rhs)));
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> andn<T>(Vector256<T> lhs, Vector256<T> rhs)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return generic<T>(Bits.andn(int8(lhs), int8(rhs)));
            else if(typematch<T,byte>())
                return generic<T>(Bits.andn(uint8(lhs), uint8(rhs)));
            else if(typematch<T,short>())
                return generic<T>(Bits.andn(int16(lhs), int16(rhs)));
            else if(typematch<T,ushort>())
                return generic<T>(Bits.andn(uint16(lhs), uint16(rhs)));
            else if(typematch<T,int>())
                return generic<T>(Bits.andn(int32(lhs), int32(rhs)));
            else if(typematch<T,uint>())
                return generic<T>(Bits.andn(uint32(lhs), uint32(rhs)));
            else if(typematch<T,long>())
                return generic<T>(Bits.andn(int64(lhs), int64(rhs)));
            else if(typematch<T,ulong>())
                return generic<T>(Bits.andn(uint64(lhs), uint64(rhs)));
            else if(typematch<T,float>())
                return generic<T>(Bits.andn(float32(lhs), float32(rhs)));
            else if(typematch<T,double>())
                return generic<T>(Bits.andn(float64(lhs), float64(rhs)));
            else 
                throw unsupported<T>();
        }
    }
}