//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IApiSig
    {
        StringRef Identifier {get;}

        CliKey TargetKey {get;}

        uint SourceCount => 0;

        ReadOnlySpan<CliKey> Sources => default;
    }

    public interface IApiSig<H> : IApiSig
        where H : unmanaged, IApiSig<H>
    {

    }

    public interface IApiSig<H,R> : IApiSig
        where H : unmanaged, IApiSig<H,R>
    {
        uint IApiSig.SourceCount
            => ApiSig<R>.SourceCount;

        CliKey IApiSig.TargetKey
            => ApiSig<R>.target();

        ReadOnlySpan<CliKey> IApiSig.Sources
            => ApiSig<R>.Sources;
    }

    public interface IApiSig<H,A,R> : IApiSig<H,R>
        where H : unmanaged, IApiSig<H,A,R>
    {
        CliKey Source(N0 n)
            => ApiSig<A,R>.source(n);

        uint IApiSig.SourceCount
            => ApiSig<A,R>.SourceCount;

        ReadOnlySpan<CliKey> IApiSig.Sources
            => ApiSig<A,R>.Sources;
    }

    public interface IApiSig<H,A,B,R> : IApiSig<H,R>
        where H : unmanaged, IApiSig<H,A,B,R>
    {
        CliKey Source(N0 n)
            => ApiSig<A,B,R>.source(n);

        CliKey Source(N1 n)
            => ApiSig<A,B,R>.source(n);

        uint IApiSig.SourceCount
            => ApiSig<A,B,R>.SourceCount;

        ReadOnlySpan<CliKey> IApiSig.Sources
            => ApiSig<A,B,R>.Sources;
    }

    public interface IApiSig<H,A,B,C,R> : IApiSig<H,R>
        where H : unmanaged, IApiSig<H,A,B,C,R>
    {
        CliKey Source(N0 n)
            => ApiSig<A,B,C,R>.source(n);

        CliKey Source(N1 n)
            => ApiSig<A,B,C,R>.source(n);

        CliKey Source(N2 n)
            => ApiSig<A,B,C,R>.source(n);

        uint IApiSig.SourceCount
            => ApiSig<A,B,C,R>.SourceCount;

        ReadOnlySpan<CliKey> IApiSig.Sources
            => ApiSig<A,B,C,R>.Sources;
    }
}