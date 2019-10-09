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
    
    using static Span256;
    using static Span128;

    partial class ginx
    {

        [MethodImpl(Inline)]
        public static Vec128<T> vbsll<T>(in Vec128<T> lhs, byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vbsll(in uint16(in lhs), count));
            else if(typeof(T) == typeof(uint)) 
                return generic<T>(dinx.vbsll(in uint32(in lhs), count));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vbsll(in uint64(in lhs), count));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vec256<T> vbsll<T>(in Vec256<T> lhs, byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vbsll(in uint16(in lhs), count));
            else if(typeof(T) == typeof(uint)) 
                return generic<T>(dinx.vbsll(in uint32(in lhs), count));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vbsll(in uint64(in lhs), count));
            else
                throw unsupported<T>();
        }
    }

}