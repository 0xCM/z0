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
        public string Group {get;}

        public OpAttribute()
        {
            Group = string.Empty;
        }

        public OpAttribute(string group)
        {
            Group = group;          
        }

        public override string ToString()
            => Group;
    }  
}