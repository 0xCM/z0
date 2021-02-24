//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = ApiCatalogs;

    public readonly struct ApiHosts : IIndex<IApiHost>
    {
        readonly Index<IApiHost> Data;

        [MethodImpl(Inline)]
        public ApiHosts(IApiHost[] src)
            => Data = src;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public Span<IApiHost> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ReadOnlySpan<IApiHost> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public ref IApiHost First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsEmpty;
        }

        public IApiHost[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public bool Host(Type t, out IApiHost host)
            => api.host(this, t, out host);

        public bool Host(ApiHostUri uri, out IApiHost host)
            => api.host(this, uri, out host);

        public string Format()
            => Seq.format(Storage);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator ApiHosts(IApiHost[] src)
            => new ApiHosts(src);

        [MethodImpl(Inline)]
        public static implicit operator IApiHost[](ApiHosts src)
            => src.Data;
    }
}