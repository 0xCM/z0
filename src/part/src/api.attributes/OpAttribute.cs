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
        public string GroupName {get;}

        public OpAttribute()
        {
            GroupName = "";
        }

        public OpAttribute(string group)
        {
            GroupName = group;          
        }

        public override string ToString()
            => GroupName;
    }  
}