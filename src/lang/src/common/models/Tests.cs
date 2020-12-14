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
        public static Tests<C> alloc<C>(uint count)
            => new Tests<C>(count);
    }

    public readonly struct Tests<C> : ITableSpan<Tests<C>,Test<C>>
    {
        readonly TableSpan<Test<C>> Data;

        [MethodImpl(Inline)]
        public Tests(Test<C>[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public Tests(uint count)
            => Data = sys.alloc<Test<C>>(count);

        [MethodImpl(Inline)]
        public static implicit operator Tests<C>(Test<C>[] src)
            => new Tests<C>(src);

        public ReadOnlySpan<Test<C>> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<Test<C>> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ref Test<C> First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public Test<C>[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }


        [MethodImpl(Inline)]
        public Tests<C> Refresh(Test<C>[] src)
            => src;
    }
}