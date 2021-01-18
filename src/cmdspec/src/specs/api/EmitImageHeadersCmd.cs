//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    [Cmd(CmdName)]
    public struct EmitImageHeadersCmd : ICmd<EmitImageHeadersCmd>
    {
        public const string CmdName = "emit-image-headers";

        public FS.Files Source;

        public FS.FilePath Target;
    }

    partial class XCmd
    {
        [MethodImpl(Inline), Op]
        public static EmitImageHeadersCmd EmitImageHeaders(this CmdBuilder wf, FS.Files src, FS.FilePath dst)
        {
            var cmd = new EmitImageHeadersCmd();
            cmd.Source = src;
            cmd.Target = dst;
            return cmd;
        }
    }
}