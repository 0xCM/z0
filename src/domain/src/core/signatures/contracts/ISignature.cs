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

    public interface ISignature<H> : ISignature
        where H : unmanaged, ISignature<H>
    {

    }

    public interface ISignature<H,R> : ISignature
        where H : unmanaged, ISignature<H,R>
    {
        public new const byte SourceCount = Sig<R>.SourceCount;

        uint ISignature.SourceCount
            => SourceCount;

        ClrArtifactKey ISignature.TargetKey
            => Sig<R>.target();

        ReadOnlySpan<ClrArtifactKey> ISignature.Sources
            => Sig<R>.Sources;
    }

    public interface ISignature<H,A,R> : ISignature<H,R>
        where H : unmanaged, ISignature<H,A,R>
    {
        public new const byte SourceCount = Sig<A,R>.SourceCount;

        ClrArtifactKey Source(N0 n)
            => Sig<A,R>.source(n);

        uint ISignature.SourceCount
            => SourceCount;

        ReadOnlySpan<ClrArtifactKey> ISignature.Sources
            => Sig<A,R>.Sources;
    }

    public interface ISignature<H,A,B,R> : ISignature<H,R>
        where H : unmanaged, ISignature<H,A,B,R>
    {
        public new const byte SourceCount = Sig<A,B,R>.SourceCount;

        ClrArtifactKey Source(N0 n)
            => Sig<A,B,R>.source(n);

        ClrArtifactKey Source(N1 n)
            => Sig<A,B,R>.source(n);

        uint ISignature.SourceCount
            => SourceCount;

        ReadOnlySpan<ClrArtifactKey> ISignature.Sources
            => Sig<A,B,R>.Sources;
    }

    public interface ISignature<H,A,B,C,R> : ISignature<H,R>
        where H : unmanaged, ISignature<H,A,B,C,R>
    {
        public new const byte SourceCount = Sig<A,B,C,R>.SourceCount;

        ClrArtifactKey Source(N0 n)
            => Sig<A,B,C,R>.source(n);

        ClrArtifactKey Source(N1 n)
            => Sig<A,B,C,R>.source(n);

        ClrArtifactKey Source(N2 n)
            => Sig<A,B,C,R>.source(n);

        uint ISignature.SourceCount
            => SourceCount;

        ReadOnlySpan<ClrArtifactKey> ISignature.Sources
            => Sig<A,B,C,R>.Sources;
    }
}