//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;

    partial class ImageDataEmitter
    {
        public void EmitProcessData()
        {
            Wf.CmdBuilder().EmitImageContent(Process.GetCurrentProcess(), out var commands);
            root.iter(commands, cmd => Wf.Router.Dispatch(cmd));
        }
    }
}