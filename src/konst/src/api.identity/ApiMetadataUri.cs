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

    public readonly struct ApiMetadataUri : ITextual
    {
        const byte PartIndex = 0;

        const byte KeyIndex = 1;

        const byte HostIndex = 2;

        const byte OpIndex = 3;

        readonly Vector128<uint> Data;

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

        public uint HostId
        {
            [MethodImpl(Inline)]
            get => vcell(Data,HostIndex);
        }

        public ArtifactKey OperationKey
        {
            [MethodImpl(Inline)]
            get => new ArtifactKey(TableIndex.MethodDef, (ClrArtifactKey)vcell(Data,OpIndex));
        }

        public uint OperationId
        {
            [MethodImpl(Inline)]
            get => vcell(Data, OpIndex);
        }

        [MethodImpl(Inline)]
        public static ApiMetadataUri identify(MethodInfo src)
        {
            var host = src.DeclaringType;
            var dst = vparts(w128, (uint)host.Assembly.Id(), (uint)src.KindId(), (uint)host.MetadataToken, (uint)src.MetadataToken);
            return new ApiMetadataUri(dst);
        }

        [MethodImpl(Inline)]
        public string Format()
        {
            const string pattern = "{0,-16} | metadata://{1}/{2}/{3}";
            return string.Format(pattern,KindKey.Format(), Part.Format(), HostId, OperationId);
        }

        public override string ToString()
            => Format();
    }
}