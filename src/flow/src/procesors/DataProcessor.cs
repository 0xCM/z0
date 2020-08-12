//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    
    public readonly ref struct DataProcessor<S,T>
    {
        internal readonly Span<S> Source;

        internal readonly Span<T> Target;

        internal uint SourceCount 
            => (uint)Source.Length;

        [MethodImpl(Inline)]
        public DataProcessor(S[] src, T[] dst)
        {
            Source = src;
            Target = dst;
        }
        
        [MethodImpl(Inline)]
        public void Process()
        {
            Process(first(Source), ref first(Target), 0u, SourceCount);                        
        }

        [MethodImpl(Inline)]
        public void Process(in S src, ref T dst, uint offset, uint count)
        {
            for(var i=offset; i<count; i++)
                Process(skip(src,i), ref seek(dst,i));
        }

        [MethodImpl(Inline)]
        public ref T Process(in S src, ref T dst)
        {
            return ref dst;
        }
    }

}