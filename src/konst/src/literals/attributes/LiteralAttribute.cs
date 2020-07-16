//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Describes an attributed literal
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class LiteralAttribute : Attribute
    {
        public LiteralAttribute(string description)
        {
            Description = description ?? Konst.EmptyString;
        }

        public string Description {get;}        
    }
}