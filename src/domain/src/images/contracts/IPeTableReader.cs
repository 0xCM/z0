//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IPeTableReader : IDisposable
    {
        ReadOnlySpan<CliSystemString> SystemStrings();

        ReadOnlySpan<CliUserString> UserStrings();

        ReadOnlySpan<CliBlob> Blobs();

        ReadOnlySpan<CliConstant> Constants();

        ReadOnlySpan<CliField> Fields();
    }
}