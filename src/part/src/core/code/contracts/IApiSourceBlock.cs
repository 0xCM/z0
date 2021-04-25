//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IApiSourceBlock : ISourceCode
    {
        ApiToken Id {get;}
    }

    public interface IApiSourceBlock<C> : IApiSourceBlock
        where C : struct, ISourceCode
    {

        C SourceCode {get;}

        ReadOnlySpan<TextLine> ISourceCode.Lines
            => SourceCode.Lines;
    }

    public interface IApiSourceBlock<B,C> : IApiSourceBlock<C>
        where C : struct, ISourceCode
        where B : struct, IApiSourceBlock<B,C>
    {

    }
}