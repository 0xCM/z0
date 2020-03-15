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