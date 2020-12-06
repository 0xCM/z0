//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    using api = ApiIdentity;

    public readonly struct ApiMetadataUri : ITextual
    {
        internal const byte PartIndex = 0;

        internal const byte HostIndex = 1;

        internal const byte KeyIndex = 2;

        internal const byte OpIndex = 3;

        internal readonly Vector128<uint> Data;

        [MethodImpl(Inline)]
        public ApiMetadataUri(Vector128<uint> src)
            => Data = src;

        public PartId Part
        {
            [MethodImpl(Inline)]
            get => api.part(this);
        }

        public CliArtifactKey HostId
        {
            [MethodImpl(Inline)]
            get => vcell(Data, HostIndex);
        }

        public ApiClass KindKey
        {
            [MethodImpl(Inline)]
            get => api.kind(this);
        }

        public CliArtifactKey OperationId
        {
            [MethodImpl(Inline)]
            get => vcell(Data, OpIndex);
        }

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        public string Identifier
        {
            [MethodImpl(Inline)]
            get => api.identifier(this);
        }

        [MethodImpl(Inline)]
        public bool Equals(ApiMetadataUri src)
            => api.eq(this,src);

        public override string ToString()
            => Format();

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => vnonz(Data);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => !vnonz(Data);
        }

        [MethodImpl(Inline)]
        public static implicit operator ApiMetadataUri(MethodInfo src)
            => api.identify(src);

        public static ApiMetadataUri Empty => default;
    }
}