//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Identifies a formal operation for inclusing in the identity assignment and catalog system
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
    public class OpAttribute : Attribute
    {
        public string Name {get;}

        public OpAttribute()
        {
            this.Name = string.Empty;
        }

        public OpAttribute(string name)
        {
            this.Name = name;          
        }

        public override string ToString()
            => Name;
    }   
}