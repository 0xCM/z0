//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows;

    using static Root;
    using static core;
    using static AsmCodes;

    partial class AsmCmdService
    {
        [CmdOp(".sigspan")]
        public Outcome sigspan(CmdArgs args)
        {
            var result = Outcome.Success;
            var name = arg(args, 0).Value;
            var lookup = AsmSigs.TokenType(name, out var type);
            if(lookup.Fail)
                return argerror(name);



            return result;
        }

    }
}