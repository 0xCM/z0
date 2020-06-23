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

    public readonly struct LiteralFieldReader
    {
        public static LiteralFieldReader Service => default;        

        public T NumericValue<T>(FieldInfo f)
            where T : unmanaged
                => (T)f.GetRawConstantValue();

        public T[] NumericValues<T>(Type src)
            where T : unmanaged
                => Fields<T>(src).Select(NumericValue<T>);

        public char CharValue(FieldInfo f)
            => (char)f.GetRawConstantValue();

        public char[] CharValues(Type src)
            => Fields<char>(src).Select(CharValue);

        public string TextValue(FieldInfo f)
            => (string)f.GetRawConstantValue();

        [MethodImpl(Inline), Op]
        public string[] TextValues(Type src)
            => TextFields(src).Select(TextValue);

        public FieldInfo[] TextFields(Type src)
            => Filter(DeclaredFields(src)).Where(f => f.FieldType == typeof(string));            
        
        public T Value<T>(FieldInfo f)
            => (T)f.GetRawConstantValue();

        public T[] Values<T>(Type src)
            => Fields<T>(src).Select(Value<T>);

        public FieldInfo[] Fields<T>(Type src)
            => Filter(DeclaredFields(src)).Where(f => f.FieldType == typeof(T));            

        FieldInfo[] Filter(FieldInfo[] src)
            => src.Where(x => x.IsLiteral);

        FieldInfo[] DeclaredFields(Type src)
            => src.DeclaredFields();                
    }
}