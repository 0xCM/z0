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

    public interface IPointSink<T> : ISink
    {
        void Accept(in T src);
    }

    public interface IBufferedPointSink<S,T> : ISink
    {
        void Accept(in S src, Span<T> buffer);
    }

    public interface IPointSink<A,B> : ISink
    {
        void Accept(in A a, in B b);
    }

    public interface IPointSink<A,B,C> : ISink
    {
        void Accept(in A a, in B b, in C c);
    }
}