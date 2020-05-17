//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Indicates the target's numeric base preference
    /// </summary>
    public class NumericBaseAttribute : Attribute
    {    
        public NumericBaseAttribute(int @base)
        {
            this.Base = (NumericBaseKind)@base;
        }

        public NumericBaseAttribute(NumericBaseKind @base)
        {
            this.Base = @base;
        }
        
        public NumericBaseKind Base {get;}
    }
}