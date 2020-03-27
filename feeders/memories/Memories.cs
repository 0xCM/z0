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

        internal const string Kernel32 = "kernel32.dll";


        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        internal static ref byte uint8<T>(ref T src)
            => ref Unsafe.As<T,byte>(ref src);

    }

    public static partial class XMem    
    {

    }

    public static partial class XTend
    {
        
    }
}
