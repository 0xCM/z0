//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;

using Z0;
using static Z0.As;

partial class zfunc
{
    public static ref T amplify<S,T>(S src, out T dst)
        where S : unmanaged
        where T : unmanaged
    {
        if(typeof(S) == typeof(byte))
            dst = amplify(As.uint8(src), out dst);
        else if(typeof(S) == typeof(ushort))
            dst = amplify(As.uint16(src), out dst);
        else if(typeof(S) == typeof(uint))
            dst = amplify(As.uint32(src), out dst);
        else
            throw unsupported<S>();
        return ref dst;
    }
    
    [MethodImpl(Inline)]
    static ref T amplify<T>(byte src, out T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(ushort))
            dst =  generic<T>(broadcast(src, out ushort target));
        else if(typeof(T) == typeof(uint))
            dst =  generic<T>(broadcast(src, out uint target));
        else if(typeof(T) == typeof(ulong))
            dst =  generic<T>(broadcast(src, out ulong target));
        else
            throw unsupported<T>();
        return ref dst;
    }

    [MethodImpl(Inline)]
    static ref T amplify<T>(ushort src, out T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(uint))
            dst =  generic<T>(broadcast(src, out uint target));
        else if(typeof(T) == typeof(ulong))
            dst =  generic<T>(broadcast(src, out ulong target));
        else
            throw unsupported<T>();
        return ref dst;
    }

    [MethodImpl(Inline)]
    static ref T amplify<T>(uint src, out T dst)
        where T : unmanaged
    {        
        if(typeof(T) == typeof(ulong))
            dst =  generic<T>(broadcast(src, out ulong target));
        else
            throw unsupported<T>();
        return ref dst;
    }

    [MethodImpl(Inline)]
    static ref ulong broadcast(uint src, out ulong dst)
    {
        dst = (ulong)src << 32 | (ulong)src;
        return ref dst;
    }

    [MethodImpl(Inline)]
    static ref uint broadcast(ushort src, out uint dst)
    {
        dst = (uint)src << 16 | (uint)src;
        return ref dst;
    }

    [MethodImpl(Inline)]
    static ref ulong broadcast(ushort src, out ulong dst)
    {
        broadcast(src, out uint first);
        broadcast(src, out uint second);
        dst = (ulong)second << 32 | (ulong)first;
        return ref dst;
    }

    [MethodImpl(Inline)]
    static ref ushort broadcast(byte src, out ushort dst)
    {
        dst = (ushort)((ushort)src << 8 | (ushort)src);
        return ref dst;
    }

    [MethodImpl(Inline)]
    static ref uint broadcast(byte src, out uint dst)
    {
        broadcast(src, out ushort first);
        broadcast(src, out ushort second);
        dst = (uint)second << 16 | (uint)first;
        return ref dst;
    }

    [MethodImpl(Inline)]
    static ref ulong broadcast(byte src, out ulong dst)
    {
        broadcast(src, out uint first);
        broadcast(src, out uint second);
        dst = (ulong)second << 32 | (ulong)first;
        return ref dst;
    }
}