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

    partial struct CmdArgs
    {
        [Op]
        public static bool lookup(CmdArgIndex src, string name, out CmdArg dst)
        {
            for(var i=0; i<src.Count; i++)
            {
                ref readonly var arg = ref src[i];
                if(text.equals(arg.Name, name))
                {
                    dst=arg;
                    return true;
                }
            }
            dst = CmdArg.Empty;
            return false;
        }
    }
}