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
    /// Defines a sequence of <see cref='ApiMemberHex'/> records
    /// </summary>
    [ApiDataType]
    public readonly struct ApiHexTable : ITableSpan<ApiMemberHex>
    {
        readonly TableSpan<ApiMemberHex> Data;

        [MethodImpl(Inline)]
        public static implicit operator ApiHexTable(ApiMemberHex[] src)
            => new ApiHexTable(src);

        [MethodImpl(Inline)]
        public ApiHexTable(ApiMemberHex[] src)
            => Data = src;

        public ReadOnlySpan<ApiMemberHex> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<ApiMemberHex> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ref ApiMemberHex First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ApiMemberHex[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }
    }
}