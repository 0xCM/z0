//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static zfunc;

    /// <summary>
    /// Attaches an anonymous binary literal value to a target
    /// </summary>
    public class BinaryLiteralAttribute : LiteralAttribute
    {
        public BinaryLiteralAttribute(string value)
            : base(value)
        {

            
        }

        public string Text 
            => (string)Value;
    }
}