//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public static class Kinds
    {
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        [MethodImpl(Inline)]
        internal static int bitsize<T>()            
            where T : unmanaged
                => Unsafe.SizeOf<T>()*8;
    }

    public static partial class XKind
    {


    }
}