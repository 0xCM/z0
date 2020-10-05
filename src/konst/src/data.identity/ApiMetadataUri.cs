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
    using System.Reflection.Metadata.Ecma335;

    using static Konst;
    using static z;

    using api = ApiIdentify;

    public readonly struct ApiMetadataUri : ITextual
    {
        const byte PartIndex = 0;

        const byte KeyIndex = 1;

        const byte HostIndex = 2;

        const byte OpIndex = 3;

        internal readonly Vector128<uint> Data;

        [MethodImpl(Inline)]
        public ApiMetadataUri(Vector128<uint> src)
            => Data = src;

        public PartId Part
        {
            [MethodImpl(Inline)]
            get => (PartId)vcell(Data, PartIndex);
        }

        public ApiOpId KindKey
        {
            [MethodImpl(Inline)]
            get => (ApiOpId)vcell(Data, KeyIndex);
        }

        public ArtifactKey HostKey
        {
            [MethodImpl(Inline)]
            get => new ArtifactKey(TableIndex.TypeDef, (ClrArtifactKey)vcell(Data,HostIndex));
        }

        public ClrArtifactKey HostId
        {
            [MethodImpl(Inline)]
            get => vcell(Data,HostIndex);
        }

        public ArtifactKey OperationKey
        {
            [MethodImpl(Inline)]
            get => new ArtifactKey(TableIndex.MethodDef, (ClrArtifactKey)vcell(Data,OpIndex));
        }

        public ClrArtifactKey OperationId
        {
            [MethodImpl(Inline)]
            get => vcell(Data, OpIndex);
        }

        [MethodImpl(Inline)]
        public static ApiMetadataUri identify(MethodInfo src)
            => api.metauri(src);

        [MethodImpl(Inline)]
        public static implicit operator ApiMetadataUri(MethodInfo src)
            => identify(src);

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
            get => z.vnonz(Data);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => !z.vnonz(Data);
        }

        public static ApiMetadataUri Empty => default;
    }
}