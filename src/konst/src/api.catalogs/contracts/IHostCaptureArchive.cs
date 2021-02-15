//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IHostCaptureArchive : IApiHostPaths
    {

    }

    public interface IHostCaptureArchive<T> : IHostCaptureArchive
        where T : struct, IHostCaptureArchive<T>
    {

    }
}