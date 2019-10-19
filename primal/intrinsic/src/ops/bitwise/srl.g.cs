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
        public static Vec128<T> vsrl<T>(in Vec128<T> lhs, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vsrl(in uint8(in lhs), offset));
            else if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vsrl(in int8(in lhs), offset));
            if(typeof(T) == typeof(short))
                return generic<T>(dinx.vsrl(in int16(in lhs), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vsrl(in uint16(in lhs), offset));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vsrl(in int32(in lhs), offset));
            else if(typeof(T) == typeof(uint)) 
                return generic<T>(dinx.vsrl(in uint32(in lhs), offset));
            else if(typeof(T) == typeof(long))
                return generic<T>(dinx.vsrl(in int64(lhs), offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vsrl(in uint64(lhs), offset));
            else
                throw unsupported<T>();
        }

       [MethodImpl(Inline)]
        public static Vec256<T> vsrl<T>(in Vec256<T> lhs, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vsrl(in uint8(in lhs), offset));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vsrl(in int16(in lhs), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vsrl(in uint16(in lhs), offset));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vsrl(in int32(in lhs), offset));
            else if(typeof(T) == typeof(uint)) 
                return generic<T>(dinx.vsrl(in uint32(in lhs), offset));
            else if(typeof(T) == typeof(long))
                return generic<T>(dinx.vsrl(in int64(lhs), offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vsrl(in uint64(lhs), offset));
            else
                throw unsupported<T>();
        }
 
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


    }
}