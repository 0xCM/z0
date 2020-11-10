//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    public readonly struct ApiDataTypes : ITableSpan<ApiDataType>
    {
        public readonly PartId Part;

        readonly TableSpan<ApiDataType> Data;

        [MethodImpl(Inline)]
        public ApiDataTypes(PartId part, ApiDataType[] types)
        {
            Part = part;
            Data = types;
        }

        public ApiDataType[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ReadOnlySpan<ApiDataType> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public ReadOnlySpan<ApiDataType> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ref ApiDataType LeadingCell
        {
            [MethodImpl(Inline)]
            get => ref z.first(Data.Edit);
        }
    }
}