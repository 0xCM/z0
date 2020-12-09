//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd(CmdName)]
    public struct EmitImageContentCmd : ICmdSpec<EmitImageContentCmd>
    {
        public const string CmdName ="emit-image-content";

        public LocatedImage Source;

        public FS.FilePath Target;
    }
}