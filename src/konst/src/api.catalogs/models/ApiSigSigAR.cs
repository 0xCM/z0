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

    public readonly struct ApiSig<A,R> : IApiSignature<ApiSig<A,R>,A,R>
    {
        public const byte SourceCount = 1;

        public const byte TypeCount = 2;

        static ClrArtifactKey[] _Sources = new ClrArtifactKey[SourceCount]{source(n0)};

        static Type[] _Types = new Type[TypeCount]{typeof(A), typeof(R)};

        public StringRef Identifier {get;}

        [MethodImpl(Inline)]
        public ApiSig(string name)
        {
            Identifier = name;
        }

        [MethodImpl(Inline)]
        public static implicit operator ApiSignature(ApiSig<A,R> src)
            => encode(src.Identifier, skip(Types,0), skip(Types,1));

        public static ClrArtifactKey target()
            => typeof(R);

        public static ClrArtifactKey source(N0 n)
            => typeof(A);

        public static ReadOnlySpan<ClrArtifactKey> Sources
            => _Sources;

        public static ReadOnlySpan<Type> Types
            => _Types;
    }
}