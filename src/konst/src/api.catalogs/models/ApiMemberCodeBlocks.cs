//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a sequence of <see cref='ApiMemberCode'/> records
    /// </summary>
    public readonly struct ApiMemberCodeBlocks : IIndex<ApiMemberCode>
    {
        readonly Index<ApiMemberCode> Data;

        [MethodImpl(Inline)]
        public ApiMemberCodeBlocks(ApiMemberCode[] src)
            => Data = src;

        public ReadOnlySpan<ApiMemberCode> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<ApiMemberCode> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ref ApiMemberCode First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ApiMemberCode[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ref ApiMemberCode this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        [MethodImpl(Inline)]
        public static implicit operator ApiMemberCodeBlocks(ApiMemberCode[] src)
            => new ApiMemberCodeBlocks(src);

        [MethodImpl(Inline)]
        public static implicit operator ApiMemberCode[](ApiMemberCodeBlocks src)
            => src.Storage;

    }
}