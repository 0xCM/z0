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
    /// Attaches an anonymous literal value to a target
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class LiteralAttribute : Attribute
    {
        public LiteralAttribute(object value)
            => this.Value = value;
        
        /// <summary>
        /// The attached literal
        /// </summary>
        public object Value {get;}
    }
}

