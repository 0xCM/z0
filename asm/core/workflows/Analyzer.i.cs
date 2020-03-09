//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;


    public interface IAnalysis
    {

    }
    
    public interface IAnalysis<R> : IAnalysis
    {    

    }

    public interface IAnalyzer
    {
        object Analyze(object src);
    }

    public interface IAnalyzer<R> : IAnalyzer
        where R : IAnalysis
    {
        new R Analyze(object src);

        object IAnalyzer.Analyze(object src)
            => Analyze(src);        
    }

    public interface IAnalyzer<S,R> : IAnalyzer<R>        
        where R : IAnalysis
    {
        R Analyze(in S src);

        [MethodImpl(Inline)]
        R IAnalyzer<R>.Analyze(object src)
            => Analyze((S)src);

        [MethodImpl(Inline)]
        Span<R> Analyze(ReadOnlySpan<S> src, Span<R> dst)
        {
            ref readonly var inputs = ref head(src);
            ref var outputs = ref head(dst);

            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var input = ref skip(inputs, i);
                seek(ref outputs,i) = Analyze(input);                
            }
            return dst;
        }

        Span<R> Analyze(ReadOnlySpan<S> src)
            => Analyze(src,alloc<R>(src.Length));        
    }

    public interface IAnalyzer<A,S,R> : IAnalyzer<S,R>        
        where R : IAnalysis
        where A : IAnalyzer<A,S,R>
    {

    }

}