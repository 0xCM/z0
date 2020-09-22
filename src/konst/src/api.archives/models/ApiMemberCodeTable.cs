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
    [ApiDataType]
    public readonly struct ApiMemberCodeTable : ITableSpan<ApiMemberCode>
    {
        readonly TableSpan<ApiMemberCode> Data;

        [MethodImpl(Inline)]
        public static implicit operator ApiMemberCodeTable(ApiMemberCode[] src)
            => new ApiMemberCodeTable(src);

        [MethodImpl(Inline)]
        public ApiMemberCodeTable(ApiMemberCode[] src)
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
    }
}