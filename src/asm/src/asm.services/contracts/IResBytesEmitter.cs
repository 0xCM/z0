//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IResBytesEmitter : IWfService
    {
        Index<ApiHostRes> Emit(ApiCodeBlocks index, FS.FolderPath dst);
    }
}