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

        public static LiteralInfo TargetValue(FieldInfo target)
        {
            var data = target.Tag<LiteralAttribute>().MapValueOrDefault(x => x.Description, string.Empty);
            if(text.empty(data))
                return LiteralInfo.Empty;            
            
            return LiteralInfo.Define(target.Name, 
                target.GetRawConstantValue(), data, 
                Type.GetTypeCode(target.FieldType), 
                target.FieldType.IsEnum, 
                false);
        }
        
        public static string Describe(FieldInfo target)
            => target.Tag<LiteralAttribute>().MapValueOrDefault(x => x.Description, string.Empty);
    }
}