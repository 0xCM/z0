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
    /// <summary>
    /// Overwrites all target bits with the pattern define by the source bits, with source pattern bits
    /// repeated or truncated as necessary
    /// </summary>
    /// <param name="src">The source bit pattern</param>
    /// <param name="dst">The target value</param>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    public static ref T zbroadcast<S,T>(S src, out T dst)
        where S : unmanaged
        where T : unmanaged
    {
        if(typeof(S) == typeof(byte))
            return ref broadcast(As.uint8(src), out dst);
        else if(typeof(S) == typeof(ushort))
            return ref broadcast(As.uint16(src), out dst);
        else if(typeof(S) == typeof(uint))
            return ref broadcast(As.uint32(src), out dst);
        else if(typeof(S) == typeof(ulong))
            return ref broadcast(As.uint64(src), out dst);
        else
            throw unsupported<S>();
    }

    /// <summary>
    /// Replicates the source values as many times as necessary to overwrite all bits in the target
    /// </summary>
    /// <param name="src">The source value</param>
    /// <param name="dst">The target value</param>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
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
    static ref T broadcast<T>(byte src, out T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte))
            dst = generic<T>(broadcast(src, out byte target));
        else if(typeof(T) == typeof(ushort))
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
    static ref byte broadcast(byte src, out byte dst)
    {
        dst = src;
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

    [MethodImpl(Inline)]
    static ref T broadcast<T>(ushort src, out T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte))
            dst = generic<T>(broadcast(src, out byte target));
        else if(typeof(T) == typeof(ushort))
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
    static ref byte broadcast(ushort src, out byte dst)
    {
        dst = (byte)src;
        return ref dst;
    }

    [MethodImpl(Inline)]
    static ref ushort broadcast(ushort src, out ushort dst)
    {
        dst = src;
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
    static ref T broadcast<T>(uint src, out T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte))
            dst = generic<T>(broadcast(src, out byte target));
        else if(typeof(T) == typeof(ushort))
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
    static ref byte broadcast(uint src, out byte dst)
    {
        dst = (byte)src;
        return ref dst;
    }

    [MethodImpl(Inline)]
    static ref ushort broadcast(uint src, out ushort dst)
    {
        dst = (ushort)src;
        return ref dst;
    }

    [MethodImpl(Inline)]
    static ref uint broadcast(uint src, out uint dst)
    {
        dst = src;
        return ref dst;
    }

    [MethodImpl(Inline)]
    static ref ulong broadcast(uint src, out ulong dst)
    {
        dst = (ulong)src << 32 | (ulong)src;
        return ref dst;
    }

    [MethodImpl(Inline)]
    static ref T broadcast<T>(ulong src, out T dst)
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte))
            dst = generic<T>(broadcast(src, out byte target));
        else if(typeof(T) == typeof(ushort))
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
    static ref byte broadcast(ulong src, out byte dst)
    {
        dst = (byte)src;
        return ref dst;
    }

    [MethodImpl(Inline)]
    static ref ushort broadcast(ulong src, out ushort dst)
    {
        dst = (ushort)src;
        return ref dst;
    }

    [MethodImpl(Inline)]
    static ref uint broadcast(ulong src, out uint dst)
    {
        dst = (uint)src;
        return ref dst;
    }

    [MethodImpl(Inline)]
    static ref ulong broadcast(ulong src, out ulong dst)
    {
        dst = src;
        return ref dst;
    }

}