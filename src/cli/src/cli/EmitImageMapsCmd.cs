//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd(CmdName)]
    public struct EmitImageMapsCmd  : ICmd<EmitImageMapsCmd>
    {
        public const string CmdName ="emit-image-maps";

        public FS.FilePath Target;
    }
}