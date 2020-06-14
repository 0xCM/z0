//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Covers a value that can be interpreted as a compile-time literal constant
    /// </summary>
    public readonly struct Literal<T> : ILiteral<Literal<T>,T> 
    {
        public static Literal<T> Empty 
            => new Literal<T>(string.Empty, default, string.Empty, 0, false, false);

        public string Name {get;}        

        public T Data {get;}

        public string Text {get;}

        public TypeCode TypeCode {get;}
        
        public bool IsEnum {get;}

        public bool MultiLiteral {get;}

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data == null || (Data is string s && string.IsNullOrWhiteSpace(s));
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public Literal<T> Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        public bool IsAnonymous
        {
            [MethodImpl(Inline)]
            get => string.IsNullOrWhiteSpace(Name);
        }

        public Type SystemType 
        {
            [MethodImpl(Inline)]
            get => Data?.GetType() ?? typeof(void);
        }
 
        [MethodImpl(Inline)]
        public static Literal<T> Define(string Name, T Data, string Text, TypeCode TypeCode, bool IsEnum, bool MultiLiteral)
            => new Literal<T>(Name,Data, Text, TypeCode, IsEnum, MultiLiteral);
        
        [MethodImpl(Inline)]
        internal Literal(string Name, T Data, string Text, TypeCode TypeCode, bool IsEnum, bool MultiLiteral)
        {
            this.Name = Name;
            this.Data = Data;
            this.Text = Text;
            this.TypeCode = TypeCode;
            this.IsEnum = IsEnum;
            this.MultiLiteral = MultiLiteral;
        }

        [MethodImpl(Inline)]
        public bool Equals(Literal<T> src)
            => object.Equals(Data,src.Data);
        
        [MethodImpl(Inline)]
        public string Format()
            => Data?.ToString() ?? string.Empty;

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Data?.GetHashCode() ?? 0;
        
        public override bool Equals(object src)
            => src is Literal<T> v && Equals(v);
    }
}