//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Identifies a formal operation for inclusing in the identity assignment and catalog system
    /// </summary>
    public class OpAttribute : Attribute
    {
        public virtual string Name {get;}

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