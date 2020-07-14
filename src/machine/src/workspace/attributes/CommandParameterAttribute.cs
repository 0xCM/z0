//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
    public class CommandParameterAttribute : Attribute    
    {
        public string ParameterName { get; set; }

        public string ParameterDescription { get; set; }

        public CommandParameterAttribute()
        {

        }

        public CommandParameterAttribute(string ParameterDescription)
        {
            this.ParameterDescription = ParameterDescription;
        }
    }
}