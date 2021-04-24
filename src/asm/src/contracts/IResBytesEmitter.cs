//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IResBytesEmitter : IAppService
    {
        Index<ApiHostRes> Emit(ApiBlockIndex index, FS.FolderPath dst);
    }
}