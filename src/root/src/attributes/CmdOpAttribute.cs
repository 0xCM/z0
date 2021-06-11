//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [AttributeUsage(AttributeTargets.Method)]
    public class CmdOpAttribute : Attribute
    {
        public string CommandName {get;}

        public CmdOpAttribute()
        {
            CommandName = String.Empty;

        }

        public CmdOpAttribute(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                CommandName = string.Empty;
            }
            else
            {
                CommandName = name;
            }
        }
    }
}