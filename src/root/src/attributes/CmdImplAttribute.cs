//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [AttributeUsage(AttributeTargets.Method)]
    public class CmdImplAttribute : Attribute
    {
        public object Cmd {get;}

        public CmdImplAttribute(object cmd)
        {
            Cmd = cmd;
        }
    }
}