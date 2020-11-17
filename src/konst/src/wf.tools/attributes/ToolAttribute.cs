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

        public string OptionDelimiter {get;}

        public string UsageSyntax {get;}

        public ToolAttribute()
        {
            ToolName = string.Empty;
            OptionDelimiter = string.Empty;
            UsageSyntax = string.Empty;
        }

        public ToolAttribute(string name)
        {
            ToolName = name ?? string.Empty;
            OptionDelimiter = string.Empty;
            UsageSyntax = string.Empty;
        }

        public ToolAttribute(string name, char delimiter, string usage = null)
        {
            ToolName = name ?? string.Empty;
            OptionDelimiter = delimiter.ToString();
            UsageSyntax = usage ?? string.Empty;
        }

        public ToolAttribute(string name, string delimiter, string usage = null)
        {
            ToolName = name ?? string.Empty;
            OptionDelimiter = delimiter;
            UsageSyntax = usage ?? string.Empty;
        }
    }
}