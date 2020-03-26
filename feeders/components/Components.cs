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

    using static Components;

    public static class Components
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        /// <summary>
        /// If the source type is a type reference, returns the referenced type; otherwise, returns the original type
        /// </summary>
        /// <param name="src">The type to examine</param>
        internal static Type EffectiveType(this Type src)
            => src.UnderlyingSystemType.IsByRef ? src.GetElementType() : src;
    }

    public static partial class XTend
    {

    }

    public static class core
    {
        [MethodImpl(Inline)]
        public static int bitsize<T>()            
            => Unsafe.SizeOf<T>()*8;

        [MethodImpl(Inline)]
        public static int size<T>()
            => Unsafe.SizeOf<T>();

        /// <summary>
        /// Explicitly casts a source value to value of the indicated type, raising an exception if operation fails
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static T cast<T>(object src) 
            => (T)src;

        [MethodImpl(Inline)]
        public static IEnumerable<T> seq<T>(params T[] src)
            => src;
        
        [MethodImpl(Inline)]
        public static T[] array<T>(params T[] src)
            => src;
    }
}