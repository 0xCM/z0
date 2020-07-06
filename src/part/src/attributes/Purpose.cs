//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Describes the reason for a thing to be
    /// </summary>
    public class PurposeAttribute : Attribute
    {
        public PurposeAttribute(string description)
        {
            Description = description ?? string.Empty;
        }
        
        public string Description {get;}
    }
}