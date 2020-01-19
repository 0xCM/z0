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
    /// Attaches an anonymous hex literal value to a target
    /// </summary>
    public class HexLiteralAttribute : LiteralAttribute
    {
        public HexLiteralAttribute(object value)
            : base(value)
        {

            
        }
    }
}