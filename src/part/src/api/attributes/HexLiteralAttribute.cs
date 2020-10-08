//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;

    /// <summary>
    /// Attaches a hex literal to a target
    /// </summary>
    public class HexLiteralAttribute : Attribute
    {
        public string Text {get;}

        public string Description {get;}

        public HexLiteralAttribute(string src)
        {
            Text = src ?? EmptyString;
            Description = EmptyString;
        }

        public HexLiteralAttribute(string src, string pattern, params byte[] args)
        {
            Text = src ?? EmptyString;
            Description = string.Format(pattern, args);
        }
    }
}