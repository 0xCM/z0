//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Attaches a muliliteral to a target
    /// </summary>
    public class MultiLiteralAttribute : Attribute
    {    
        readonly string Data;

        public MultiLiteralAttribute(string data)
        {
            Data = data;
        }
        
        [MethodImpl(Inline)]
        public static bool Attached(FieldInfo target)
            => Attribute.IsDefined(target, typeof(MultiLiteralAttribute));
        
        public static LiteralValue TargetValue(FieldInfo target)
            => target.Tag<MultiLiteralAttribute>()
                     .MapValueOrDefault(tag => TargetValue(target, tag.Data), LiteralValue.Empty);

        static LiteralValue TargetValue(FieldInfo target, string Text)
            => LiteralValue.Define(
                Name: target.Name, 
                Data: target.GetRawConstantValue(), 
                Text: Text,
                TypeCode: Type.GetTypeCode(target.FieldType), 
                IsEnum: target.FieldType.IsEnum, 
                MultiLiteral: true
                );

    }
}