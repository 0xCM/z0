//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Characterizes a segment reference
    /// </summary>
    public interface IMemorySegment : INullity, ITextual, IHashed
    {
        uint DataSize  {get;}

        bool INullity.IsEmpty
            => DataSize == 0;

        uint CellCount
            => DataSize * CellSize;

        uint CellSize
            => 1;

        ref byte Cell(int index);

        ref byte this[int index]
            => ref Cell(index);
    }

    /// <summary>
    /// Characterizes a content-parametric segment reference
    /// </summary>
    /// <typeparam name="T">The content type</typeparam>
    public interface ISegRef<T> : IMemorySegment
    {
        Span<S> As<S>();

        new ref T Cell(int index);

        ref byte IMemorySegment.Cell(int index)
            => ref Unsafe.As<T,byte>(ref Cell(index));

        uint IMemorySegment.CellSize
            => (uint)Unsafe.SizeOf<T>();

        new ref T this[int index]
            => ref Cell(index);
    }

    /// <summary>
    /// Characterizes a reified content-parameteric segment reference
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="T">The content type</typeparam>
    public interface ISegRef<F,T> : ISegRef<T>, INullary<F>, IEquatable<F>
        where F : ISegRef<F,T>, new()
    {
        F INullary<F>.Zero
            => new F();
    }

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