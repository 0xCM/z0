//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    public static class LiteralAttributes
    {
        public static NumericLiteral BinaryLiteral(FieldInfo target, object value)
        {
            if(!HasBinaryLiteral(target))
                return NumericLiteral.Empty;
            return NumericLiterals.base2(target.Name, value, target.Tag<BinaryLiteralAttribute>().Value.Text);
        }

        public static bool HasBinaryLiteral(FieldInfo target)
            => Attribute.IsDefined(target, typeof(BinaryLiteralAttribute));

        public static bool HasMultiLiteral(FieldInfo target)
            => Attribute.IsDefined(target, typeof(MultiLiteralAttribute));
    }
}