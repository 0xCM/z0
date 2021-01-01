//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Cmd(CmdName)]
    public struct EmitImageHeadersCmd : ICmdSpec<EmitImageHeadersCmd>
    {
        public const string CmdName = "emit-image-headers";

        public FS.Files Source;

        public FS.FilePath Target;
    }
}