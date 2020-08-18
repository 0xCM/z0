//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    /// <summary>
    /// Attaches a binary literal value to a target or identifies a literal field
    /// </summary>
    public class StringLiteralAttribute : Attribute
    {
        public string Text {get;}
        
        public StringLiteralAttribute(string src)
        {
            Text = src ?? string.Empty;
        }

        public StringLiteralAttribute()
        {
            Text = string.Empty;
        }        
    }
}