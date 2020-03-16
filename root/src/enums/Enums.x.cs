//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;

    public static class EnumX
    {
        [MethodImpl(Inline)]
        public static bool IsDefined<E>(this E e)
            where E : unmanaged, Enum
                => Enum.IsDefined(typeof(E), e);

        [MethodImpl(Inline)]
        public static bool IsSome<E>(this E src)        
            where E : unmanaged, Enum            
                => !Enums.zero<E>().Equals(src);

        [MethodImpl(Inline)]
        public static bool IsNone<E>(this E src)        
            where E : unmanaged, Enum            
                => Enums.zero<E>().Equals(src);

        [MethodImpl(Inline)]
        public static T MapSomeOrElse<E,T>(this E kind, Func<E,T> ifSome, Func<T> ifNone)
            where E : unmanaged, Enum
                => kind.IsSome() ? ifSome(kind) : ifNone();
        
        /// <summary>
        /// Puts an enum value into a (numeric) box
        /// </summary>
        /// <param name="e">The enumeration value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static BoxedNumber Box<E>(this E src)
            where E : unmanaged, Enum            
                => Enums.box(src);

        [MethodImpl(Inline)]
        public static TypeCode TypeCode(this EnumValueCode k)
            =>(System.TypeCode)k;

        [MethodImpl(Inline)]
        public static NumericKind NumericKind(this EnumValueCode k)
            => k.TypeCode().NumericKind();

        public static EnumLiterals<E> ToIndex<E>(this IEnumerable<EnumLiteral<E>> src)
            where E : unmanaged, Enum
                => new EnumLiterals<E>(src.ToArray());
    }
}