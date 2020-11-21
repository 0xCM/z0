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

    public interface ISignature
    {
        StringRef Identifier {get;}

        ClrArtifactKey TargetKey {get;}

        uint SourceCount => 0;

        ReadOnlySpan<ClrArtifactKey> Sources => default;
    }

    public interface IApiSignature<H> : ISignature
        where H : unmanaged, IApiSignature<H>
    {

    }

    public interface ISignature<H,R> : ISignature
        where H : unmanaged, ISignature<H,R>
    {
        public new const byte SourceCount = ApiSig<R>.SourceCount;

        uint ISignature.SourceCount
            => SourceCount;

        ClrArtifactKey ISignature.TargetKey
            => ApiSig<R>.target();

        ReadOnlySpan<ClrArtifactKey> ISignature.Sources
            => ApiSig<R>.Sources;
    }

    public interface IApiSignature<H,A,R> : ISignature<H,R>
        where H : unmanaged, IApiSignature<H,A,R>
    {
        public new const byte SourceCount = ApiSig<A,R>.SourceCount;

        ClrArtifactKey Source(N0 n)
            => ApiSig<A,R>.source(n);

        uint ISignature.SourceCount
            => SourceCount;

        ReadOnlySpan<ClrArtifactKey> ISignature.Sources
            => ApiSig<A,R>.Sources;
    }

    public interface IApiSignature<H,A,B,R> : ISignature<H,R>
        where H : unmanaged, IApiSignature<H,A,B,R>
    {
        public new const byte SourceCount = ApiSig<A,B,R>.SourceCount;

        ClrArtifactKey Source(N0 n)
            => ApiSig<A,B,R>.source(n);

        ClrArtifactKey Source(N1 n)
            => ApiSig<A,B,R>.source(n);

        uint ISignature.SourceCount
            => SourceCount;

        ReadOnlySpan<ClrArtifactKey> ISignature.Sources
            => ApiSig<A,B,R>.Sources;
    }

    public interface IApiSignature<H,A,B,C,R> : ISignature<H,R>
        where H : unmanaged, IApiSignature<H,A,B,C,R>
    {
        public new const byte SourceCount = ApiSig<A,B,C,R>.SourceCount;

        ClrArtifactKey Source(N0 n)
            => ApiSig<A,B,C,R>.source(n);

        ClrArtifactKey Source(N1 n)
            => ApiSig<A,B,C,R>.source(n);

        ClrArtifactKey Source(N2 n)
            => ApiSig<A,B,C,R>.source(n);

        uint ISignature.SourceCount
            => SourceCount;

        ReadOnlySpan<ClrArtifactKey> ISignature.Sources
            => ApiSig<A,B,C,R>.Sources;
    }
}