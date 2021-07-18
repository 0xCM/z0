//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".srclist")]
        Outcome SrcList(CmdArgs args)
        {
            if(args.Count !=0)
            {
                if(Arg(args,0,out var pattern))
                    SrcList(SrcDir().Files(pattern.Value,false));
            }
            else
                SrcList(SrcDir().AllFiles);
            return true;
        }

    }
}