//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct BinaryLiterals
    {        
        [MethodImpl(Inline), Op, Closures(Integers8x64k)]
        public static bool eq<T>(BinaryLiteral<T> x, BinaryLiteral<T> y)
            where T : unmanaged
                => BinaryLiteral.eq(x,y);

        [MethodImpl(Inline), Op]
        public static bool eq(BinaryLiteral x, BinaryLiteral y)
            => BinaryLiteral.eq(x,y);

        [MethodImpl(Inline)]
        public static bool empty(in BinaryLiteral src)
            => BinaryLiteral.empty(src); 

        [MethodImpl(Inline), Op, Closures(Integers8x64k)]
        public static bool empty<T>(in BinaryLiteral<T> src)
            where T : unmanaged
                => BinaryLiteral.empty(src); 
        
        [MethodImpl(Inline)]
        public static bool nonempty(in BinaryLiteral src)
            => BinaryLiteral.nonempty(src); 

        [MethodImpl(Inline), Op, Closures(Integers8x64k)]
        public static bool nonempty<T>(in BinaryLiteral<T> src)
            where T : unmanaged
                => BinaryLiteral.nonempty(src); 

        public static string format(BinaryLiteral src) 
            => BinaryLiteral.format(src);

        public static string format<T>(BinaryLiteral<T> src) 
            where T : unmanaged
                => BinaryLiteral.format(src); 

        /// <summary>
        /// Discerns the numeric kind of a specified binary literal
        /// </summary>
        /// <param name="src">The source literal</param>
        [MethodImpl(Inline), Op]
        public static NumericKind kind(BinaryLiteral src)
            => BinaryLiteral.kind(src);

        /// <summary>
        /// Discerns the numeric kind of a specified binary literal
        /// </summary>
        /// <param name="src">The source literal</param>
        [MethodImpl(Inline), Op, Closures(Integers8x64k)]
        public static NumericKind kind<T>(BinaryLiteral<T> src)
            where T : unmanaged
                => BinaryLiteral.kind(src);

        [MethodImpl(Inline), Op, Closures(Integers8x64k)]
        public static T[] values<T>(Base2 @base, Type src)
            where T : unmanaged
        {
            var literals = valspan<T>(@base,src);
            var count = literals.Length;            
            var buffer = sys.alloc<T>(count);
            var dst = span(buffer);
            for(var i=0u; i< count; i++)        
                seek(dst,i) = skip(literals,i);
            return buffer;                    
        }

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
        static ReadOnlySpan<T> valspan<T>(Base2 @base, Type src)
            where T : unmanaged
                => from f in src.LiteralFields()
                   where f.FieldType == typeof(T) && f.Tagged<BinaryLiteralAttribute>()
                   let a = f.Tag<BinaryLiteralAttribute>().Require()
                   select (T)f.GetRawConstantValue();
    }
}