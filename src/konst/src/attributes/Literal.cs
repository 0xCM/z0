//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Describes an attributed literal
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class LiteralAttribute : Attribute
    {
        public LiteralAttribute(string description)
        {
            Description = description;
        }

        public string Description {get;}        
    }
}