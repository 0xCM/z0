//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct ApiIdentity<T> : ITextual
    {
        public readonly PartId Part;

        public readonly ClrArtifactKey HostId;

        public readonly T Identifier;

        public readonly ushort ApiKey;

        [MethodImpl(Inline)]
        public ApiIdentity(PartId part, ClrArtifactKey host, T id, ushort apikey)
        {
            Part = part;
            HostId = host;
            ApiKey = apikey;
            Identifier = id;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Identifier?.ToString() ?? EmptyString;

        public override string ToString()
            => Format();
    }
}