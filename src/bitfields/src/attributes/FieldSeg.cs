//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    public class FieldSegAttribute : BinaryLiteralAttribute
    {
        public FieldSegAttribute(string description)
            : base(description)
        {
            
        }        
    }
}