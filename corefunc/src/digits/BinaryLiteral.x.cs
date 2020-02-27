//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;
    
    public static class BinaryLiteralX
    {
        /// <summary>
        /// Selects the binary literals declared by a type that are of a specified parametric primal type
        /// </summary>
        /// <param name="src">The source type</param>
        /// <typeparam name="T">The primal literal type</typeparam>
        public static IEnumerable<BinaryLiteral<T>> BinaryLiterals<T>(this Type src)
            where T : unmanaged
            => from f in src.LiteralFields()
                where f.FieldType == typeof(T) && f.Tagged<BinaryLiteralAttribute>()
               let a = f.Tag<BinaryLiteralAttribute>().Require()
                select BinaryLiteral.Define(f.Name, (T)f.GetValue(null), a.Text);

        /// <summary>
        /// Selects the binary literals declared by a type
        /// </summary>
        /// <param name="src">The source type</param>
        public static IEnumerable<BinaryLiteral> BinaryLiterals(this Type src)
            => from f in src.LiteralFields()
                where f.Tagged<BinaryLiteralAttribute>()
               let a = f.Tag<BinaryLiteralAttribute>().Require()
                select BinaryLiteral.Define(f.Name, f.GetValue(null), a.Text);

        public static string Format(this BinaryLiteral src) 
            => $"{src.Name}({src.Value}:{src.Kind.Keyword()}) := " + text.enquote(src.Text);

        public static string Format<T>(this BinaryLiteral<T> src) 
            where T : unmanaged
                => $"{src.Name}({src.Value}:{src.Kind.Keyword()}) := " + text.enquote(src.Text);
    }
}