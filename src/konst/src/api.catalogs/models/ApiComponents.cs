//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ApiComponents : IIndex<ApiComponents,uint,ApiComponent>
    {
        readonly Index<ApiComponent> Data;

        [MethodImpl(Inline)]
        public ApiComponents(ApiComponent[] src)
            => Data = src;

        public ref ApiComponent this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ApiComponent[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public ReadOnlySpan<ApiComponent> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ref ApiComponent LeadingCell
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public Span<ApiComponent> Terms
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public static implicit operator ApiComponents(ApiComponent[] src)
            => new ApiComponents(src);
    }
}