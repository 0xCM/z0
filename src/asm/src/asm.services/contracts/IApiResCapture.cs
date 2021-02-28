//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface IApiResCapture : IWfService
    {
        Index<CapturedApiRes> CaptureApiRes(FS.FilePath src, FS.FolderPath dst);

        void Emit(ReadOnlySpan<CapturedApiRes> src, FS.FilePath dst);
    }

}