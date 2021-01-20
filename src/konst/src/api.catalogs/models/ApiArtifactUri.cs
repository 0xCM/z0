//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Runtime.Intrinsics;

    using static Part;
    using static z;

    using api = ApiIdentity;

    public readonly struct ApiArtifactUri : ITextual
    {
        internal const byte HostIndex = 1;

        internal const byte OpIndex = 3;

        internal readonly Vector128<uint> Data;

        [MethodImpl(Inline)]
        public ApiArtifactUri(Vector128<uint> src)
            => Data = src;

        public PartId Part
        {
            [MethodImpl(Inline)]
            get => api.part(this);
        }

        public ClrToken HostId
        {
            [MethodImpl(Inline)]
            get => vcell(Data, HostIndex);
        }

        public ApiClass KindKey
        {
            [MethodImpl(Inline)]
            get => api.kind(this);
        }

        public ClrToken OperationId
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
        public bool Equals(ApiArtifactUri src)
            => api.eq(this,src);

        public override string ToString()
            => Format();

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => cpu.vnonz(Data);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => !cpu.vnonz(Data);
        }

        [MethodImpl(Inline)]
        public static implicit operator ApiArtifactUri(MethodInfo src)
            => api.artifact(src);

        public static ApiArtifactUri Empty => default;
    }
}