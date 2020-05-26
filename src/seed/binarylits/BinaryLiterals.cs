//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Seed;

    public class BinaryLiterals
    {
        [MethodImpl(Inline)]
        public static BinaryLiteral define(string name, object value, string text)
            => new BinaryLiteral(name,value,text);

        [MethodImpl(Inline)]
        public static BinaryLiteral<T> define<T>(string name, T value, string text)
            where T : unmanaged
                => new BinaryLiteral<T>(name,value,text);

        /// <summary>
        /// Discerns the numeric kind of a specified binary literal
        /// </summary>
        /// <param name="src">The source literal</param>
        [MethodImpl(Inline)]
        public static NumericKind kind<T>(BinaryLiteral<T> src)
            where T : unmanaged
                => NumericKinds.kind<T>();

        /// <summary>
        /// Discerns the numeric kind of a specified binary literal
        /// </summary>
        /// <param name="src">The source literal</param>
        [MethodImpl(Inline)]
        public static NumericKind kind(BinaryLiteral src)
            => src.Value?.GetType()?.NumericKind() ?? NumericKind.None;

        public static T[] values<T>(Type declarer)
            where T : unmanaged
        {
            var literals = attributed<T>(declarer).ToReadOnlySpan();        
            var count = literals.Length;
            var dst = Control.alloc<T>(count);

            Span<T> target = dst;
            
            for(var i=0; i< count; i++)        
                Control.seek(target,i) = Control.skip(literals,i).Value;
            return dst;            
        }

        /// <summary>
        /// Selects the binary literals declared by a type that are of a specified parametric primal type
        /// </summary>
        /// <param name="src">The source type</param>
        /// <typeparam name="T">The primal literal type</typeparam>
        public static IEnumerable<BinaryLiteral<T>> attributed<T>(Type src)
            where T : unmanaged
                => from f in src.LiteralFields()
                   where f.FieldType == typeof(T) && f.Tagged<BinaryLiteralAttribute>()
                   let a = f.Tag<BinaryLiteralAttribute>().Require()
                   select define(f.Name, (T)f.GetValue(null), a.Text);

        /// <summary>
        /// Selects the binary literals declared by a type
        /// </summary>
        /// <param name="src">The source type</param>
        public static IEnumerable<BinaryLiteral> attributed(Type src)
            => from f in src.LiteralFields()
               where f.Tagged<BinaryLiteralAttribute>()
               let a = f.Tag<BinaryLiteralAttribute>().Require()
               select define(f.Name, f.GetValue(null), a.Text);

        public static string format(BinaryLiteral src) 
            => $"{src.Name}({src.Value}:{kind(src).Keyword()}) := " + text.enquote(src.Text);

        public static string format<T>(BinaryLiteral<T> src) 
            where T : unmanaged
                => $"{src.Name}({src.Value}:{kind(src).Keyword()}) := " + text.enquote(src.Text);
    }
}