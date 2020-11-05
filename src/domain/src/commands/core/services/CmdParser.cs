//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;


    public struct CmdParser
    {
        CmdId Id;

        TableSpan<CmdArg> Args;

        CmdParser(byte args)
        {
            Args = alloc<CmdArg>(args);
        }
        public CmdSpec Parse(CmdLine src)
        {
            return default;
        }
    }

}