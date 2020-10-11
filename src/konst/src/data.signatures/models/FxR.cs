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
    using static Signatures;

    public readonly struct Sig<R> : ISignature<Sig<R>,R>
    {
        public const byte SourceCount = 0;

        public const byte TypeCount = 1;

        public StringRef Identifier {get;}

        [MethodImpl(Inline)]
        public Sig(string id)
        {
            Identifier = id;
        }

        static Type[] _Types = new Type[TypeCount]{typeof(R)};

        public static implicit operator Signature(Sig<R> src)
            => define(src.Identifier, skip(Types,0));

        public static ClrArtifactKey target()
            => skip(Types,0);

        public static ReadOnlySpan<ClrArtifactKey> Sources
            => default;

        public static ReadOnlySpan<Type> Types
            => _Types;
    }
}