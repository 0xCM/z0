//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    partial struct Buffers
    {
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static unsafe Span<T> fill<T>(ReadOnlySpan<T> src, BufferToken dst)
        //     where T : unmanaged
        // {
        //     var srcBytes = bytes(src);
        //     var dstBytes = cover<byte>(dst);
        //     if(srcBytes.Length <= dst.Size)
        //     {
        //         if(srcBytes.Length < dst.Size)
        //             dstBytes.Clear();

        //         srcBytes.CopyTo(dstBytes);
        //     }
        //     else
        //         srcBytes.Slice(dst.Size).CopyTo(dstBytes);  

        //     return cover<T>(dst);         
        // }

        // /// <summary>
        // /// Reimagines a readonly span of generic values as a span of readonly bytes
        // /// </summary>
        // /// <param name="src">The source span</param>
        // /// <typeparam name="T">The source span element type</typeparam>
        // [MethodImpl(Inline)]
        // static ReadOnlySpan<byte> bytes<T>(ReadOnlySpan<T> src)
        //     where T : struct
        //         => MemoryMarshal.AsBytes(src);        
    }
}