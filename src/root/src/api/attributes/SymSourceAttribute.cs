//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class SymSourceAttribute : Attribute
    {
        public SymSourceAttribute()
        {
            GroupName = "";
        }

        public SymSourceAttribute(string group)
        {
            GroupName = group;
        }

        public string GroupName {get;}
    }
}