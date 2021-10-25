//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rules
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Sum<T>
        where T : IExpr
    {
        readonly Index<T> Data;

        [MethodImpl(Inline)]
        public Sum(T[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public Sum(uint count)
            => Data = core.alloc<T>(count);

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

        [MethodImpl(Inline)]
        public static implicit operator Sum<T>(T[] src)
            => new Sum<T>(src);
    }    
}