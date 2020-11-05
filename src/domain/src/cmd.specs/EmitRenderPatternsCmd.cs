//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Cmd]
    public struct EmitRenderPatternsCmd : ICmdSpec<EmitRenderPatternsCmd>
    {
        public ClrType Source;

        public FS.FilePath Target;
    }
}