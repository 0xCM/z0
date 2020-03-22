// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;    
    using System.Reflection;

    using static Root;
    
    public static class RootSpanX
    {
        /// <summary>
        /// Projects a source span to target span via a supplied transformation
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="f">The transformation</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        public static T[] ArrayMap<S,T>(this ReadOnlySpan<S> src, Func<S, T> f)
        {
            var dst = new T[src.Length];
            for(var i= 0; i<src.Length; i++)
                dst[i] = f(src[i]);
            return dst;
        }

        /// <summary>
        /// Renders a non-allocating mutable view over a source span segment that is presented as an individual target value
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The index of the first source element</param>
        /// <param name="length">The number of source elements required to constitute a target type</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T Singleton<S,T>(this Span<S> src, int offset = 0, int? length = null)
            where S : unmanaged
            where T : unmanaged
                => ref MemoryMarshal.AsRef<T>(src.AsBytes(offset,length));

        static void ThrowEmptySpanError()
            => throw new Exception($"The span is empty");
            
        public static T Reduce<T>(this ReadOnlySpan<T> src, Func<T,T,T> f)
        {
            if(src.IsEmpty)
                ThrowEmptySpanError();
            else if(src.Length == 1)
                return MemoryMarshal.GetReference(src);
            
            var x = src[0];
            for(var i=1; i<src.Length; i++)
                x = f(x,src[i]);
            return x;            
        }


        [MethodImpl(Inline)]
        public static T Reduce<T>(this Span<T> src, Func<T,T,T> f)
            => src.ReadOnly().Reduce(f);        
    }
}