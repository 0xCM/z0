//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class CmdParamAttribute : Attribute
    {
        public CmdParamAttribute()
        {
            Name = "";
        }

        public CmdParamAttribute(string name)
        {
            Name = name;
        }

        /// <summary>
        /// The commoan name that serves as a contextual identifier
        /// </summary>
        public string Name {get;}
    }
}