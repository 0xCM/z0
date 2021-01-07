//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    partial struct ClrLiterals
    {
        [MethodImpl(Inline), Op]
        public static LiteralInfo multiliteral(FieldInfo target, string Text)
            => describe(
                Name: target.Name,
                Data: target.GetRawConstantValue(),
                Text: Text,
                TypeCode: Type.GetTypeCode(target.FieldType),
                IsEnum: target.FieldType.IsEnum,
                MultiLiteral: true
                );

        [Op]
        public static LiteralInfo multiliteral(FieldInfo target)
            => target.Tag<MultiLiteralAttribute>()
                     .MapValueOrDefault(tag => multiliteral(target, tag.Data), LiteralInfo.Empty);
    }
}