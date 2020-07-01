//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Root;

    [ApiHost]
    public readonly struct BinaryLiterals
    {        
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static bool eq<T>(BinaryLiteral<T> x, BinaryLiteral<T> y)
            where T : unmanaged
                => string.Equals(x.Text, y.Text) 
                && object.Equals(x.Data, y.Data) 
                && string.Equals(x.Name, y.Name);

        [MethodImpl(Inline), Op]
        public static bool eq(BinaryLiteral x, BinaryLiteral y)
            => string.Equals(x.Text, y.Text) 
            && object.Equals(x.Data, y.Data) 
            && string.Equals(x.Name, y.Name);

        /// <summary>
        /// Selects the binary literals declared by a type
        /// </summary>
        /// <param name="src">The source type</param>
        public static BinaryLiteral[] attributed(Base2 @base, Type src)
            => from f in src.LiteralFields()
               where f.Tagged<BinaryLiteralAttribute>()
               let a = f.Tag<BinaryLiteralAttribute>().Require()
               select literal(@base, f.Name, f.GetRawConstantValue(), a.Text);

        /// <summary>
        /// Selects the binary literals declared by a type that are of a specified parametric primal type
        /// </summary>
        /// <param name="src">The source type</param>
        /// <typeparam name="T">The primal literal type</typeparam>
        public static BinaryLiteral<T>[] attributed<T>(Base2 @base, Type src)
            where T : unmanaged
                => from f in src.LiteralFields()
                   where f.FieldType == typeof(T) && f.Tagged<BinaryLiteralAttribute>()
                   let a = f.Tag<BinaryLiteralAttribute>().Require()
                   select literal(@base, f.Name, (T)f.GetRawConstantValue(), a.Text);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static T[] values<T>(Base2 @base, Type src)
            where T : unmanaged
        {
            var literals = valspan<T>(@base,src);
            var count = literals.Length;            
            var buffer = sys.alloc<T>(count);
            var dst = span(buffer);
            for(var i=0; i< count; i++)        
                seek(dst,i) = skip(literals,i);
            return buffer;                    
        }

        /// <summary>
        /// Discerns the numeric kind of a specified binary literal
        /// </summary>
        /// <param name="src">The source literal</param>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static NumericKind kind<T>(BinaryLiteral<T> src)
            where T : unmanaged
                => NumericKinds.kind<T>();

        /// <summary>
        /// Discerns the numeric kind of a specified binary literal
        /// </summary>
        /// <param name="src">The source literal</param>
        [MethodImpl(Inline), Op]
        public static NumericKind kind(BinaryLiteral src)
            => src.Data?.GetType()?.NumericKind() ?? NumericKind.None;

        public static string format(BinaryLiteral src) 
            => $"{src.Name}({src.Data}:{kind(src).Keyword()}) := " + text.enquote(src.Text);

        public static string format<T>(BinaryLiteral<T> src) 
            where T : unmanaged
                => $"{src.Name}({src.Data}:{kind(src).Keyword()}) := " + text.enquote(src.Text);

        /// <summary>
        /// Selects the binary literals declared by a type that are of a specified parametric primal type
        /// </summary>
        /// <param name="src">The source type</param>
        /// <typeparam name="T">The primal literal type</typeparam>
        static ReadOnlySpan<T> valspan<T>(Base2 @base, Type src)
            where T : unmanaged
                => from f in src.LiteralFields()
                   where f.FieldType == typeof(T) && f.Tagged<BinaryLiteralAttribute>()
                   let a = f.Tag<BinaryLiteralAttribute>().Require()
                   select (T)f.GetRawConstantValue();
    }
}