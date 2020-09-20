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
    using static TableFunctions;

    public readonly ref struct WfDataHandler<S,T>
    {
        readonly Span<S> Source;

        readonly Span<T> Target;

        readonly Map<S,T> Fx;

        readonly IWfShell Wf;

        [MethodImpl(Inline)]
        public WfDataHandler(IWfShell wf, Map<S,T> f, S[] src, T[] dst)
        {
            Wf = wf;
            Fx = f;
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public void Run()
        {
            Map(first(Source), ref first(Target), 0u, (uint)Source.Length);
        }

        [MethodImpl(Inline)]
        public void Map(in S src, ref T dst, uint offset, uint count)
        {
            for(var i=offset; i<count; i++)
                Map(skip(src,i), ref seek(dst,i));
        }

        [MethodImpl(Inline)]
        public ref T Map(in S src, ref T dst)
            => ref Fx(src, ref dst);

        public void Dispose()
        {

        }
    }
}