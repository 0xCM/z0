//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IPartCaptureArchive : IPartCapturePaths
    {

    }

    public interface IPartCaptureArchive<T> : IPartCaptureArchive
        where T : struct, IPartCaptureArchive<T>
    {

    }
}