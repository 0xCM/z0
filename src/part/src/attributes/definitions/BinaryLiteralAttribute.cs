//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    /// <summary>
    /// Attaches a binary literal value to a target
    /// </summary>
    public class BinaryLiteralAttribute : Attribute
    {
        public string Text {get;}
        
        public BinaryLiteralAttribute(string src)
        {
            Text = src ?? string.Empty;
        }
    }
}