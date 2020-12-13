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
    using static ApiSigs;

    public readonly struct ApiSig<A,B,C,R> : IApiSig<ApiSig<A,B,C,R>,A,B,C,R>
    {
        public const byte SourceCount = 3;

        public const byte TypeCount = 4;

        static CliArtifactKey[] _SourceKeys = new CliArtifactKey[SourceCount]{source(n0), source(n1), source(n2)};

        static Type[] _Types = new Type[TypeCount]{typeof(A), typeof(B), typeof(C), typeof(R)};

        public StringRef Identifier {get;}

        [MethodImpl(Inline)]
        public ApiSig(string id)
        {
            Identifier = id;
        }

        [MethodImpl(Inline)]
        public static implicit operator ApiSig(ApiSig<A,B,C,R> src)
            => encode(src.Identifier, skip(Types,0), skip(Types,1), skip(Types,2), skip(Types,3));

        public static CliArtifactKey target()
            => typeof(R);

        public static CliArtifactKey source(N0 n)
            => typeof(A);

        public static CliArtifactKey source(N1 n)
            => typeof(B);

        public static CliArtifactKey source(N2 n)
            => typeof(C);

        public static ReadOnlySpan<CliArtifactKey> Sources
            => _SourceKeys;

        public static ReadOnlySpan<Type> Types
            => _Types;
    }
}