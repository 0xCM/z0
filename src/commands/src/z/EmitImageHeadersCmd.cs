//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Cmd]
    public struct EmitImageHeadersCmd : ICmdSpec<EmitImageHeadersCmd>
    {
        public FS.Files Source;

        public FS.FilePath Target;
    }
}