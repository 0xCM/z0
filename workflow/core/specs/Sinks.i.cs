//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    /// <summary>
    /// Accepts streams of arbitrary length
    /// </summary>
    /// <param name="src">The source content</param>
    /// <typeparam name="T">The stream element type</typeparam>
    public delegate void StreamReceiver<T>(IEnumerable<T> src);

    public delegate void SpanReceiver<T>(Span<T> src);

    public delegate void ObjectReceiver<T>(in T src)
        where T : class;

    public interface ISpanSink<T> : ISink
    {
        void Accept(Span<T> src);
    }

    public interface IStreamSink<T> : ISink
    {
        void Accept(IEnumerable<T> src);
    }    
}