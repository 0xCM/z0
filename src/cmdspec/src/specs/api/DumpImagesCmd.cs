//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Cmd(CmdName)]
    public struct DumpImagesCmd : ICmdSpec<DumpImagesCmd>
    {
        public const string CmdName = "dump-images";

        public FS.FolderPath Source;

        public FS.FolderPath Target;
    }

    partial class XCmd
    {
        [MethodImpl(Inline), Op]
        public static DumpImagesCmd DumpImages(this CmdBuilder builder, FS.FolderPath src, FS.FolderPath dst)
        {
            var cmd = new DumpImagesCmd();
            cmd.Source = src;
            cmd.Target = dst;
            return cmd;
        }
    }
}