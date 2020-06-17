//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface ISpanSource<T>
    {
        Span<T> Data {get;}   
    }

    /// <summary>
    /// Characterizes an orchestrator that coordinates data transmission
    /// </summary>
    public interface ISpanFlow<T> : IFlow
        where T : struct
    {
        [MethodImpl(Inline)]
        ref T Flow(ref T src, ISpanPipe<T> dst)
            => ref dst.Flow(ref src);            

        [MethodImpl(Inline)]
        Span<T> Flow(Span<T> src, ISpanPipe<T> dst)
            => dst.Flow(src);

        Span<T> Flow(ISpanSource<T> source, ISpanPipe<T> pipe)
            => Flow(source.Data, pipe);
    }
}