//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IConstRef : IRef
    {
        ReadOnlySpan<S> As<S>();                

    }
    
    public interface IConstRef<T> : IConstRef
    {
        uint IRef.CellSize
            => (uint)Unsafe.SizeOf<T>();

        ref readonly T Cell(int index);

        ref readonly T this[int index]
            => ref Cell(index);
    }

    public interface IConstRef<F,T> : IConstRef<T>, INullary<F>, IEquatable<F>
        where F : IConstRef<F,T>, new()
    {
        F INullary<F>.Zero 
            => new F();
    }        
}