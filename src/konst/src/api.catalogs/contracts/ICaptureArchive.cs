//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ICaptureArchive : IApiPartPaths
    {

    }

    public interface ICaptureArchive<T> : ICaptureArchive
        where T : struct, ICaptureArchive<T>
    {

    }
}