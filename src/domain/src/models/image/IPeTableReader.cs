//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IPeTableReader : IDisposable
    {
        ReadOnlySpan<ImageStringRecord> ReadStrings();

        ReadOnlySpan<ImageStringRecord> ReadUserStrings();

        ReadOnlySpan<ImgBlobRecord> ReadBlobs();

        ReadOnlySpan<ImageConstantRecord> ReadConstants();

        ReadOnlySpan<ImageFieldTable> ReadFields();

        ReadOnlySpan<ImageFieldRvaRecord> ReadFieldRva();
    }
}