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
    using System.Runtime.Intrinsics;
    using static zfunc;
    using static As;
    using static AsIn;
    
    partial class ginx
    {    
        [MethodImpl(Inline)]
        public static Vector128<T> vsrl<T>(Vector128<T> lhs, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vsrl(uint8(lhs), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vsrl(uint16(lhs), offset));
            else if(typeof(T) == typeof(uint)) 
                return generic<T>(dinx.vsrl(uint32(lhs), offset));
            else 
                return generic<T>(dinx.vsrl(uint64(lhs), offset));
        }


        [MethodImpl(Inline)]
        public static Vector256<T> vsrl<T>(Vector256<T> lhs, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vsrl(uint8(lhs), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vsrl(uint16(lhs), offset));
            else if(typeof(T) == typeof(uint)) 
                return generic<T>(dinx.vsrl(uint32(lhs), offset));
            else 
                return generic<T>(dinx.vsrl(uint64(lhs), offset));
        }


        [MethodImpl(Inline)]
        public static unsafe Vector128<T> vsrl<T>(N128 n, in T pX, byte offset)
            where T : unmanaged
        {                    
            vload(pX, out Vector128<T> vA);
            return vsrl(vA,offset);
        }

        [MethodImpl(Inline)]
        public static unsafe void vsrl<T>(N128 n, in T pX, byte offset, ref T pDst)
            where T : unmanaged
                => vstore(vsrl(n, in pX, offset), ref pDst);


        [MethodImpl(Inline)]
        public static unsafe Vector256<T> vsrl<T>(N256 n, in T pX, byte offset)
            where T : unmanaged
        {                    
            vload(pX, out Vector256<T> vA);
            return vsrl(vA,offset);
        }

        [MethodImpl(Inline)]
        public static unsafe void vsrl<T>(N256 n, in T pX, byte offset, ref T pDst)
            where T : unmanaged
                => vstore(vsrl(n,in pX, offset), ref pDst);
 
    }
}