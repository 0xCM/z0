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
    using static ApiSignatures;

    public readonly struct ApiSig<R> : ISignature<ApiSig<R>,R>
    {
        public const byte SourceCount = 0;

        public const byte TypeCount = 1;

        public StringRef Identifier {get;}

        [MethodImpl(Inline)]
        public ApiSig(string id)
        {
            Identifier = id;
        }

        static Type[] _Types = new Type[TypeCount]{typeof(R)};

        public static implicit operator ApiSignature(ApiSig<R> src)
            => encode(src.Identifier, skip(Types,0));

        public static CliArtifactKey target()
            => skip(Types,0);

        public static ReadOnlySpan<CliArtifactKey> Sources
            => default;

        public static ReadOnlySpan<Type> Types
            => _Types;
    }
}