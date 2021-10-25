//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rules
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct SumOfProducts<T> : IExpr
        where T : IExpr
    {
        readonly Index<Product<T>> Data;

        [MethodImpl(Inline)]
        public SumOfProducts(Product<T>[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public SumOfProducts(uint count)
            => Data = sys.alloc<Product<T>>(count);

        public ReadOnlySpan<Product<T>> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<Product<T>> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ref Product<T> First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public Product<T>[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public ref Product<T> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref Product<T> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public string Format()
            => rules.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator SumOfProducts<T>(Product<T>[] src)
            => new SumOfProducts<T>(src);
    }    
}