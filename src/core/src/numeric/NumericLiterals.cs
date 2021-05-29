//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static NumericCast;

    using NBK = NumericBaseKind;

    [ApiHost]
    public readonly struct NumericLiterals
    {
        const NumericKind Closure = AllNumeric;

        [MethodImpl(Inline)]
        public static T zero<T>()
            where T : unmanaged
                => default(T);

        [MethodImpl(Inline), Op]
        public static NumericLiteral literal(string Name, object Value, string Text, NBK @base)
            => new NumericLiteral(Name,Value,Text, @base);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static NumericLiteral<T> literal<T>(string Name, T data, string Text, NBK @base)
            where T : unmanaged
                => new NumericLiteral<T>(Name,data, Text, @base);

        [MethodImpl(Inline), Op]
        public static NumericLiteral literal(Base2 b, string Name, object Value, string Text)
            => new NumericLiteral(Name, Value, Text, NBK.Base2);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static NumericLiteral<T> literal<T>(Base2 b, string Name, T Value, string Text)
            where T : unmanaged
                => new NumericLiteral<T>(Name, Value, Text, NBK.Base2);

        [MethodImpl(Inline), Op]
        public static NumericLiteral literal(Base10 b, string Name, object Value, string Text)
            => new NumericLiteral(Name, Value, Text, NBK.Base10);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static NumericLiteral<T> literal<T>(Base10 b, string Name, T data, string Text)
            where T : unmanaged
            => new NumericLiteral<T>(Name, data, Text, NBK.Base10);

        [MethodImpl(Inline), Op]
        public static NumericLiteral literal(Base16 b, string Name, object Value, string Text)
            => new NumericLiteral(Name, Value, Text, NBK.Base16);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static NumericLiteral<T> literal<T>(Base16 b,  string Name, T data, string Text)
            where T : unmanaged
                => new NumericLiteral<T>(Name, data, Text, NBK.Base16);

        [MethodImpl(Inline), Op]
        public static BinaryLiteral binary(Base2 @base2, string name, object value, string text)
            => new BinaryLiteral(name,value,text);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static BinaryLiteral<T> binary<T>(Base2 @base2, string name, T value, string text)
            where T : unmanaged
                => new BinaryLiteral<T>(name, value, text);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T one<T>()
            where T : unmanaged
                => force<T>(1);

        /// <summary>
        /// Ones all bits each and every ... one
        /// </summary>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T ones<T>()
            where T : unmanaged
                => ones_u<T>();

        [MethodImpl(Inline)]
        static T ones_u<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return force<T>(Ones8u);
            else if(typeof(T) == typeof(ushort))
                return force<T>(Ones16u);
            else if(typeof(T) == typeof(uint))
                return force<T>(Ones32u);
            else if(typeof(T) == typeof(ulong))
                return force<T>(Ones64u);
            else
                return ones_i<T>();
        }

        [MethodImpl(Inline)]
        static T ones_i<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return force<T>(Ones8i);
            else if(typeof(T) == typeof(short))
                return force<T>(Ones16i);
            else if(typeof(T) == typeof(int))
                return force<T>(Ones32i);
            else if(typeof(T) == typeof(long))
                return force<T>(Ones64i);
            else
                 return ones_f<T>();
       }

        [MethodImpl(Inline)]
        static T ones_f<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return force<T>((float)Ones32u);
            else if(typeof(T) == typeof(double))
                return force<T>((double)Ones64u);
            else
                 throw no<T>();
       }

        const byte Ones8u = byte.MaxValue;

        const sbyte Ones8i = -1;

        const ushort Ones16u = ushort.MaxValue;

        const short Ones16i = -1;

        const uint Ones32u = uint.MaxValue;

        const int Ones32i = -1;

        const ulong Ones64u = ulong.MaxValue;

        const long Ones64i = -1;
    }
}