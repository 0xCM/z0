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
    using System.Linq;
    using System.Reflection;

    public static class Components
    {
        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        [MethodImpl(Inline)]
        internal static int bitsize<T>()            
            where T : unmanaged
                => Unsafe.SizeOf<T>()*8;

        /// <summary>
        /// If the source type is a type reference, returns the referenced type; otherwise, returns the original type
        /// </summary>
        /// <param name="src">The type to examine</param>
        internal static Type EffectiveType(this Type src)
            => src.UnderlyingSystemType.IsByRef ? src.GetElementType() : src;

        [MethodImpl(Inline)]
        internal static IEnumerable<T> items<T>(params T[] src)
            => src;

    }
}