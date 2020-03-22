//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
 
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