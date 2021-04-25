//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ISourceCode : INullity
    {
        ReadOnlySpan<TextLine> Lines {get;}

        uint LineCount
            => (uint)Lines.Length;

        bool INullity.IsEmpty
            => LineCount == 0;

        bool INullity.IsNonEmpty
            => LineCount != 0;

    }

    public interface ISourceCode<T> : ISourceCode
        where T : struct, ISourceCode<T>
    {

    }
}