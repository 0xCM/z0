//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Diagnostics;

    using static z;

    partial class ImageEmitters
    {
        public void EmitProcessData()
        {
            Wf.CmdBuilder().EmitImageContent(Process.GetCurrentProcess(), out var commands);
            iter(commands, cmd => Wf.Router.Dispatch(cmd));
        }
    }
}