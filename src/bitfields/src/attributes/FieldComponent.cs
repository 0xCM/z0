//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;

    /// <summary>
    /// Identifies a bitfield component specification
    /// </summary>
    [AttributeUsage(AttributeTargets.Enum)]
    public class FieldComponentAttribute : Attribute
    {
        public FieldComponentAttribute()
        {

        }

        public FieldComponentAttribute(Type fieldType)
        {
            this.FieldType = fieldType;
        }

        public Type FieldType {get;}
    }
}