//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface IManageCaptureStep : ICaptureStep
    {
        void CaptureCatalogs(AsmArchiveConfig config, params PartId[] parts);
        
        void CaptureCatalogs(ICaptureArchive dst, params PartId[] parts);

        void CaptureHost(ICaptureHostStep step, IApiHost host, ICaptureArchive dst);

        void CaptureCatalog(IApiCatalog src, ICaptureArchive dst);
    }
}