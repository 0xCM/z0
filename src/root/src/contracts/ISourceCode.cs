//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ISourceCode : INullity
    {
        uint LineCount {get;}

        bool INullity.IsEmpty
            => LineCount == 0;

        bool INullity.IsNonEmpty
            => LineCount != 0;

    }

    public interface ISourceCode<C> : ISourceCode
    {
        ReadOnlySpan<C> View {get;}

        uint ISourceCode.LineCount
            => (uint)View.Length;
    }

    public interface ISourceCode<T,C> : ISourceCode<C>
        where T : struct, ISourceCode<T,C>
    {

    }
}