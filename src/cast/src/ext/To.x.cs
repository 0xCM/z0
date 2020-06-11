//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    public static partial class XTend  { }

    partial class XTend
    {
        /// <summary>
        /// Convers a source value, which is hopefully a supported kind, to a target kind
        /// </summary>
        /// <param name="k">The primal kind</param>
        [MethodImpl(Inline)]
        public static object To(this NumericKind dst, object src)
            => Cast.to(src,dst);                    

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> To<T>(this ReadOnlySpan<int> src)
            where T : unmanaged
                => NumericSpan.to<int,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> To<T>(this Span<long> src)
            where T : unmanaged
                => NumericSpan.to<long,T>(src);
   }
}