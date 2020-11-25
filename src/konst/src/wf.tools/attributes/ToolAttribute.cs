//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Identifies and elaborates a tool specification
    /// </summary>
    public class ToolAttribute : Attribute
    {
        public string ToolName {get;}

        public string UsageSyntax {get;}

        public ToolAttribute()
        {
            ToolName = string.Empty;
            UsageSyntax = string.Empty;
        }

        public ToolAttribute(string name)
        {
            ToolName = name ?? string.Empty;
            UsageSyntax = string.Empty;
        }
    }
}