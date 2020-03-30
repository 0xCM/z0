//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Components)]

namespace Z0.Parts
{        
    public sealed class Components : Part<Components>
    {


    }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    public static class Components
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        public const string Kernel32 = "kernel32.dll";

        [MethodImpl(Inline)]
        internal static IEnumerable<T> seq<T>(params T[] src)
            => src;

        [MethodImpl(Inline)]
        internal static int bitsize<T>()            
            => Unsafe.SizeOf<T>()*8;

        [MethodImpl(Inline)]
        internal static int size<T>()
            => Unsafe.SizeOf<T>();

        [MethodImpl(Inline)]
        internal static NatVal natval<K>(K n = default)
            where K : unmanaged, ITypeNat
                => NatVal.From(default(K).NatValue);
    }

    public static partial class XTend
    {

    }
}