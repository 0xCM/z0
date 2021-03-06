//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ITextProcessor
    {
        void ProcessFile(FS.FilePath src);
    }

    public interface ITextProcessor<T> : ITextProcessor
    {
        Outcome<T> ProcessLine(uint number, ReadOnlySpan<char> chars);
    }
}