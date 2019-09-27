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
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    

    using static zfunc;    
    using static As;
    
    partial class ginx
    {
        /// <summary>
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// lower 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the lower 64 bits of the second source vector
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<T> unpacklo<T>(Vector128<T> lhs, Vector128<T> rhs)        
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return generic<T>(UnpackLow(lhs.As<T,sbyte>(), rhs.As<T,sbyte>()));
            else if(typematch<T,byte>())
                return generic<T>(UnpackLow(lhs.As<T,byte>(), rhs.As<T,byte>()));
            else if(typematch<T,short>())
                return generic<T>(UnpackLow(lhs.As<T,short>(), rhs.As<T,short>()));
            else if(typematch<T,ushort>())
                return generic<T>(UnpackLow(lhs.As<T,ushort>(), rhs.As<T,ushort>()));
            else if(typematch<T,int>())
                return generic<T>(UnpackLow(lhs.As<T,int>(), rhs.As<T,int>()));
            else if(typematch<T,uint>())
                return generic<T>(UnpackLow(lhs.As<T,uint>(), rhs.As<T,uint>()));
            else if(typematch<T,long>())
                return generic<T>(UnpackLow(lhs.As<T,long>(), rhs.As<T,long>()));
            else if(typematch<T,ulong>())
                return generic<T>(UnpackLow(lhs.As<T,ulong>(), rhs.As<T,ulong>()));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// lower 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the lower 128 bits of the second source vector
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<T> unpacklo<T>(Vector256<T> lhs, Vector256<T> rhs)        
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return generic<T>(UnpackLow(lhs.As<T,sbyte>(), rhs.As<T,sbyte>()));
            else if(typematch<T,byte>())
                return generic<T>(UnpackLow(lhs.As<T,byte>(), rhs.As<T,byte>()));
            else if(typematch<T,short>())
                return generic<T>(UnpackLow(lhs.As<T,short>(), rhs.As<T,short>()));
            else if(typematch<T,ushort>())
                return generic<T>(UnpackLow(lhs.As<T,ushort>(), rhs.As<T,ushort>()));
            else if(typematch<T,int>())
                return generic<T>(UnpackLow(lhs.As<T,int>(), rhs.As<T,int>()));
            else if(typematch<T,uint>())
                return generic<T>(UnpackLow(lhs.As<T,uint>(), rhs.As<T,uint>()));
            else if(typematch<T,long>())
                return generic<T>(UnpackLow(lhs.As<T,long>(), rhs.As<T,long>()));
            else if(typematch<T,ulong>())
                return generic<T>(UnpackLow(lhs.As<T,ulong>(), rhs.As<T,ulong>()));
            else
                throw unsupported<T>();
        }


    }

}