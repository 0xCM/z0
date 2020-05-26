//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Attaches an anonymous binary literal value to a target
    /// </summary>
    public class BinaryLiteralAttribute : Attribute
    {
        public BinaryLiteralAttribute(string src)
        {
            Text = src;
        }

        public string Text {get;}            
    }
}