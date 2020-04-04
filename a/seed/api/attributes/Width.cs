//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    /// <summary>
    /// Applied directly to a type, or subclassed, to specify the physical or logical type width
    /// </summary>
    [AttributeUsage(AttributeTargets.Struct)]
    public class WidthAttribute : Attribute
    {            
        public WidthAttribute(TypeWidth width)
        {
            this.TypeWidth = width;
        }

        /// <summary>
        /// The logical width of the attributed type
        /// </summary>
        public TypeWidth TypeWidth {get;}
    }
}