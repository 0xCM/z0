//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;

    [AttributeUsage(AttributeTargets.Class)]
    public class CommandPatternAttribute : Attribute
    {

        public CommandPatternAttribute()
        {

        }

        public CommandPatternAttribute(string CommandName)
        {
            this.CommandName = CommandName;
        }


        public string CommandName { get; }

        public override string ToString()
            => CommandName ?? String.Empty;
    }
}