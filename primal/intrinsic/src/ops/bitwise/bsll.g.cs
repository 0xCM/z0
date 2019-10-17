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
    
    using static Span256;
    using static Span128;

    partial class ginx
    {

        [MethodImpl(Inline)]
        public static Vector128<T> vbsll<T>(Vector128<T> lhs, byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vbsll(uint16(lhs), count));
            else if(typeof(T) == typeof(uint)) 
                return generic<T>(dinx.vbsll(uint32(lhs), count));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vbsll(uint64(lhs), count));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vbsll<T>(Vector256<T> lhs, byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vbsll(uint16(lhs), count));
            else if(typeof(T) == typeof(uint)) 
                return generic<T>(dinx.vbsll(uint32(lhs), count));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vbsll(uint64(lhs), count));
            else
                throw unsupported<T>();
        }
    }

}