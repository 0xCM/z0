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
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        [MethodImpl(Inline)]
        internal static int bitsize<T>()            
            => Unsafe.SizeOf<T>()*8;

        [MethodImpl(Inline)]
        internal static int bitsize<T>(T rep)            
            => Unsafe.SizeOf<T>()*8;

        [MethodImpl(Inline)]
        internal static int size<T>()
            => Unsafe.SizeOf<T>();
        
        // [MethodImpl(Inline)]
        // internal static ReadOnlySpan<T> ReadOnly<T>(this Span<T> src)
        //     => src;


    }

    public static partial class XMem    
    {

    }

    public static partial class XTend
    {
        
    }
}
