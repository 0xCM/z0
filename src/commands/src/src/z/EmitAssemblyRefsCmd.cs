//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd]
    public struct EmitAssemblyRefsCmd : ICmdSpec<EmitAssemblyRefsCmd>
    {
        public Files Sources;

        public FS.FilePath Target;
    }
}