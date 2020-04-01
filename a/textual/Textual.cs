//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Textual)]

namespace Z0.Parts
{        
    public sealed class Textual : Part<Textual>
    {


    }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Collections.Generic;

    using static Seed;

    public static class Textual
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        /// <summary>
        /// Applies a function to a value
        /// </summary>
        /// <param name="x">The source value</param>
        /// <param name="f">The function to apply</param>
        /// <typeparam name="X">The source value type</typeparam>
        /// <typeparam name="Y">The output value type</typeparam>
        [MethodImpl(Inline)]   
        internal static Y apply<X,Y>(X x,Func<X,Y> f)
            => f(x);

        /// <summary>
        /// Constructs a enumerable from a parameter array
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        internal static IEnumerable<T> seq<T>(params T[] src)
            => src;

        [MethodImpl(Inline)]
        internal static T? unvalued<T>()
            where T : struct
                => (T?)null;

    }

    public static partial class XText    
    {

    }

    public static partial class XTend
    {
    }
}