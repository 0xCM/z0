//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ApiPartCatalogs : IIndexedView<ApiPartCatalogs,uint,IApiPartCatalog>
    {
        readonly IndexedView<IApiPartCatalog> Data;

        [MethodImpl(Inline)]
        public ApiPartCatalogs(IApiPartCatalog[] src)
            => Data = src;

        public IApiPartCatalog[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ReadOnlySpan<IApiPartCatalog> Terms
        {
            [MethodImpl(Inline)]
            get => Data.Terms;
        }

        public Type[] EnumTypes
        {
            [MethodImpl(Inline)]
            get => Data.Storage.SelectMany(x => x.Owner.Enums());
        }

        public string Format()
            => Seq.format(this);

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