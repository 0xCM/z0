//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Identifies a tool command
    /// </summary>
    [AttributeUsage(AttributeTargets.Struct)]
    public class ToolCmdAttribute : Attribute
    {
        public ToolCmdAttribute()
        {
            ToolName = "";
        }

        public ToolCmdAttribute(string tool)
        {
            ToolName = tool;
        }

        public string ToolName {get;}
    }
}