//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IPeTableReader : IDisposable
    {
        ReadOnlySpan<CliSystemStringRecord> SystemStrings();

        ReadOnlySpan<CliUserStringRecord> UserStrings();

        ReadOnlySpan<CliBlobRecord> Blobs();

        ReadOnlySpan<CliConstantRecord> Constants();

        ReadOnlySpan<CliFieldRecord> Fields();
    }
}