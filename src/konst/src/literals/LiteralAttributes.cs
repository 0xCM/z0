//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public static class LiteralAttributes
    {
        public static NumericLiteral BinaryLiteral(FieldInfo target, object value)
        {
            if(!HasBinaryLiteral(target))
                return NumericLiteral.Empty;

            return NumericLiteral.Base2(target.Name, value,
                target.Tag<BinaryLiteralAttribute>().Value.Text);
        }

        public static bool HasBinaryLiteral(FieldInfo target)
            => Attribute.IsDefined(target, typeof(BinaryLiteralAttribute));

        public static bool HasMultiLiteral(FieldInfo target)
            => Attribute.IsDefined(target, typeof(MultiLiteralAttribute));

        public static LiteralInfo MultiLiteral(FieldInfo target)
            => target.Tag<MultiLiteralAttribute>()
                     .MapValueOrDefault(tag => TargetValue(target, tag.Data), LiteralInfo.Empty);

        static LiteralInfo TargetValue(FieldInfo target, string Text)
            => LiteralInfo.define(
                Name: target.Name,
                Data: target.GetRawConstantValue(),
                Text: Text,
                TypeCode: Type.GetTypeCode(target.FieldType),
                IsEnum: target.FieldType.IsEnum,
                MultiLiteral: true
                );
    }
}