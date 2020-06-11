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
            var tagged = target.Tagged<LiteralAttribute>();
            if(tagged)
            {
                var attrib = (LiteralAttribute)target.GetCustomAttribute(typeof(LiteralAttribute));
                var data = attrib.Description;
                if(!string.IsNullOrWhiteSpace(data))
                    return LiteralInfo.Define(target.Name, 
                    target.GetRawConstantValue(), data, 
                    Type.GetTypeCode(target.FieldType), 
                    target.FieldType.IsEnum, 
                    false);
            }
            return LiteralInfo.Empty;
        }
        
        public static string Describe(FieldInfo target)
            => TargetValue(target).Text;
    }
}