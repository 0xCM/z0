//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ApiPartCatalogs : IIndexedView<ApiPartCatalogs,uint,IApiPartCatalog>
    {
        readonly Index<IApiPartCatalog> Data;

        [MethodImpl(Inline)]
        public ApiPartCatalogs(IApiPartCatalog[] src)
            => Data = src;

        public IApiPartCatalog[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public ReadOnlySpan<IApiPartCatalog> View
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public string Format()
            => Data.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator ApiPartCatalogs(IApiPartCatalog[] src)
            => new ApiPartCatalogs(src);

        [MethodImpl(Inline)]
        public static implicit operator IApiPartCatalog[](ApiPartCatalogs src)
            => src.Data.Storage;
    }
}