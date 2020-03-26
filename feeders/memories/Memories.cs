//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Memories)]

namespace Z0.Parts
{        
    public sealed class Memories : Part<Memories> { }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public static class Memories
    {
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        internal const string Kernel32 = "kernel32.dll";

        /// <summary>
        /// Computes the byte-size of a type
        /// </summary>
        /// <typeparam name="T">The type</typeparam>
        [MethodImpl(Inline)]
        internal static int size<T>()
            => Unsafe.SizeOf<T>();

        /// <summary>
        /// Computes the bit-width of a type
        /// </summary>
        /// <param name="t">A type representative</param>
        /// <typeparam name="T">The type</typeparam>    
        [MethodImpl(Inline)]
        internal static int bitsize<T>()            
            where T : unmanaged
                => Unsafe.SizeOf<T>()*8;

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        internal static ref byte uint8<T>(ref T src)
            => ref Unsafe.As<T,byte>(ref src);

    }

    public static partial class XMem    
    {

    }
}
