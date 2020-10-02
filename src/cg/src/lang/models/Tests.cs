//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Tests
    {
        [MethodImpl(Inline)]
        public static Tests<C,T> alloc<C,T>(uint count)
            => new Tests<C,T>(count);
    }

    public readonly struct Tests<C,T> : ITableSpan<Tests<C,T>,Test<C,T>>
    {
        readonly TableSpan<Test<C,T>> Data;

        [MethodImpl(Inline)]
        public Tests(Test<C,T>[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public Tests(uint count)
            => Data = sys.alloc<Test<C,T>>(count);

        [MethodImpl(Inline)]
        public static implicit operator Tests<C,T>(Test<C,T>[] src)
            => new Tests<C,T>(src);

        public ReadOnlySpan<Test<C,T>> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<Test<C,T>> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ref Test<C,T> First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public Test<C, T>[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }


        [MethodImpl(Inline)]
        public Tests<C,T> Refresh(Test<C,T>[] src)
            => src;

    }
}