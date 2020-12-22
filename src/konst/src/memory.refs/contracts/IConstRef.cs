//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IConstRef : IMemorySegment
    {
        ReadOnlySpan<S> As<S>();
    }

    public interface IConstRef<T> : IConstRef
    {
        uint IMemorySegment.CellSize
            => (uint)Unsafe.SizeOf<T>();

        new ref readonly T Cell(int index);

        new ref readonly T this[int index]
            => ref Cell(index);
    }

    public interface IConstRef<F,T> : IConstRef<T>, INullary<F>, IEquatable<F>
        where F : IConstRef<F,T>, new()
    {
        F INullary<F>.Zero
            => new F();
    }
}