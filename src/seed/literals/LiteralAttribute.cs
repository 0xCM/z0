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
            this.Description = description;
        }

        public string Description {get;}        

        public static string Describe(FieldInfo target)
            => target.Tag<LiteralAttribute>().MapValueOrDefault(x => x.Description, string.Empty);
    }
}