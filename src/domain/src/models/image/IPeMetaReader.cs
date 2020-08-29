//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IPeMetaReader : IDisposable
    {
        ReadOnlySpan<ImageString> ReadStrings();

        ReadOnlySpan<ImageString> ReadUserStrings();

        ReadOnlySpan<ImgBlobRecord> ReadBlobs();

        ReadOnlySpan<ImgConstantRecord> ReadConstants();

        ReadOnlySpan<ImgFieldRecord> ReadFields();

        ReadOnlySpan<ImgFieldRva> ReadFieldRva();
    }
}