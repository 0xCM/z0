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