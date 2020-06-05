//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Seed;
    using static Memories;

    public readonly struct LiteralFieldReader
    {
        public static LiteralFieldReader Service => default;        

        [MethodImpl(Inline), Op, NumericClosures(UnsignedInts)]
        public T NumericValue<T>(FieldInfo f)
            where T : unmanaged
                => (T)f.GetRawConstantValue();

        [MethodImpl(Inline), Op, NumericClosures(UnsignedInts)]
        public T[] NumericValues<T>(Type src)
            where T : unmanaged
                => Fields<T>(src).Select(NumericValue<T>);

        [MethodImpl(Inline), Op]
        public char CharValue(FieldInfo f)
            => (char)f.GetRawConstantValue();

        [MethodImpl(Inline), Op]
        public char[] CharValues(Type src)
            => Fields<char>(src).Select(CharValue);

        [MethodImpl(Inline), Op]
        public string TextValue(FieldInfo f)
            => (string)f.GetRawConstantValue();

        [MethodImpl(Inline), Op]
        public string[] TextValues(Type src)
            => TextFields(src).Select(TextValue);

        [MethodImpl(Inline), Op]
        public FieldInfo[] TextFields(Type src)
            =>Filter(DeclaredFields(src)).Where(f => f.FieldType == typeof(string));            
        
        [MethodImpl(Inline)]
        public T Value<T>(FieldInfo f)
            => (T)f.GetRawConstantValue();

        [MethodImpl(Inline)]
        public T[] Values<T>(Type src)
            => Fields<T>(src).Select(Value<T>);

        [MethodImpl(Inline)]
        public FieldInfo[] Fields<T>(Type src)
            => Filter(DeclaredFields(src)).Where(f => f.FieldType == typeof(T));            

        [MethodImpl(Inline), Op]
        FieldInfo[] Filter(FieldInfo[] src)
            => src.Where(x => x.IsLiteral);

        [MethodImpl(Inline), Op]
        FieldInfo[] DeclaredFields(Type src)
            => src.DeclaredFields();                
    }
}