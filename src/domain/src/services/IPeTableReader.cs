//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IPeTableReader : IDisposable
    {
        ReadOnlySpan<SystemStringRecord> SystemStrings();

        ReadOnlySpan<UserStringRecord> UserStrings();

        ReadOnlySpan<ImageBlob> Blobs();

        ReadOnlySpan<ImageConstantRecord> Constants();

        ReadOnlySpan<ImageFieldTable> Fields();
    }
}