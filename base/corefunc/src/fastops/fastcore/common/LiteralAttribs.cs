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

    /// <summary>
    /// Attaches a named literal value to a target
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class NamedLiteralAttribute : LiteralAttribute
    {
        public NamedLiteralAttribute(string name, object value)
            : base(value)
        {
            this.Name = name;
        }

        /// <summary>
        /// The name of the literal
        /// </summary>
        public string Name {get;}
    }    
}

