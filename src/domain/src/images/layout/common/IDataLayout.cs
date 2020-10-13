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

    public interface IDataLayout : ITextual
    {
        LayoutIdentity Id {get;}

        uint Index => Id.Index;

        ulong Kind => Id.Kind;

        ulong Width {get;}
    }

    public interface IDataLayout<H> : IDataLayout
        where H : struct, IDataLayout<H>
    {

    }

    public interface IDataLayout<H,S> : IDataLayout<H>
        where H : struct, IDataLayout<H,S>
        where S : struct
    {
        ReadOnlySpan<S> Sections {get;}


        uint SectionCount
            => (uint)Sections.Length;
    }
}