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

        ReadOnlySpan<ImageBlobRecord> Blobs();

        ReadOnlySpan<ImageConstantRecord> Constants();

        ReadOnlySpan<ImageFieldRecord> Fields();
    }
}