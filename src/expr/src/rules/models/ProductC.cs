//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rules
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines a conunction of expressions
    /// </summary>
    public readonly struct Product<T> : IExpr
        where T : IExpr
    {
        readonly Index<T> Data;

        [MethodImpl(Inline)]
        public Product(T[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public Product(uint count)
            => Data = sys.alloc<T>(count);

        public ReadOnlySpan<T> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<T> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ref T First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public T[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public ref T this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref T this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public string Format()
            => rules.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Product<T>(T[] src)
            => new Product<T>(src);
    }    
}