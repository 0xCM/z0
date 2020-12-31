//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    partial struct Literals
    {
        public static LiteralInfo tagged(FieldInfo target)
        {
            var tagged = target.Tagged<LiteralAttribute>();
            if(tagged)
            {
                var attrib = (LiteralAttribute)target.GetCustomAttribute(typeof(LiteralAttribute));
                var data = attrib.Description;
                if(!string.IsNullOrWhiteSpace(data))
                    return describe(target.Name,
                    target.GetRawConstantValue(), data,
                    Type.GetTypeCode(target.FieldType),
                    target.FieldType.IsEnum,
                    false);
            }
            return LiteralInfo.Empty;
        }

        /// <summary>
        /// Selects the binary literals declared by a type that are of a specified parametric primal type
        /// </summary>
        /// <param name="src">The source type</param>
        /// <typeparam name="T">The primal literal type</typeparam>
        public static BinaryLiterals<T> tagged<T>(Base2 @base, Type src)
            where T : unmanaged
                => from f in src.LiteralFields()
                   where f.FieldType == typeof(T) && f.Tagged<BinaryLiteralAttribute>()
                   let a = f.Tag<BinaryLiteralAttribute>().Require()
                   select z.literal(@base, f.Name, (T)f.GetRawConstantValue(), a.Text);

        /// <summary>
        /// Selects the binary literals declared by a type
        /// </summary>
        /// <param name="src">The source type</param>
        public static BinaryLiteral[] tagged(Base2 @base, Type src)
            => from f in src.LiteralFields()
               where f.Tagged<BinaryLiteralAttribute>()
               let a = f.Tag<BinaryLiteralAttribute>().Require()
               select z.literal(@base, f.Name, f.GetRawConstantValue(), a.Text);
    }
}