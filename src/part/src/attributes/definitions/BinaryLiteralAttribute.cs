//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;

    /// <summary>
    /// Attaches a binary literal value to a target
    /// </summary>
    public class BinaryLiteralAttribute : Attribute
    {
        public string Text {get;}

        public string Description {get;}

        public BinaryLiteralAttribute(string src)
        {
            Text = src ?? EmptyString;
            Description = EmptyString;
        }

        public BinaryLiteralAttribute(string src, string pattern, params byte[] args)
        {
            Text = src ?? EmptyString;
            Description = string.Format(pattern, args);
        }
    }
}