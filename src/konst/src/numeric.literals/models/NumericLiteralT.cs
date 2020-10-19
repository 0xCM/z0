//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    using NBK = NumericBaseKind;
    
    /// <summary>
    /// Defines a numeric literal relative to a specified base
    /// </summary>
    public readonly struct NumericLiteral<T> : INumericLiteral<NumericLiteral<T>,T>
        where T : unmanaged
    {
        public string Name {get;}
        
        public T Data {get;}

        public string Text {get;}

        public NBK Base {get;}
        
        [MethodImpl(Inline)]
        public static NumericLiteral<T> Base2(string Name, T Value, string Text)
            => new NumericLiteral<T>(Name, Value, Text, NBK.Base2);

        [MethodImpl(Inline)]
        public static NumericLiteral<T> Base10(string Name, T data, string Text)
            => new NumericLiteral<T>(Name, data, Text, NBK.Base10);

        [MethodImpl(Inline)]
        public static NumericLiteral<T> Base16(string Name, T data, string Text)
            => new NumericLiteral<T>(Name, data, Text, NBK.Base16);

        [MethodImpl(Inline)]
        public static NumericLiteral<T> Define(string Name, T data, string Text, NBK @base)
            => new NumericLiteral<T>(Name,data, Text, @base);

        [MethodImpl(Inline)]
        public NumericLiteral(string name, T data, string text, NBK @base)
        {
            Name = name;
            Data = data;
            Text = text ?? data.ToString();
            Base = @base;
        }        

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => string.IsNullOrWhiteSpace(Text);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public bool HasValue
        {
            [MethodImpl(Inline)]
            get => !Data.Equals(default);
        }

        public Type SystemType 
        {
            [MethodImpl(Inline)]
            get => Data.GetType();
        }

        public TypeCode TypeCode  
        {
            [MethodImpl(Inline)]
            get => Type.GetTypeCode(SystemType);
        }

        public NumericLiteral<T> Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        public bool IsEnum 
        {
            [MethodImpl(Inline)]
            get => SystemType.IsEnum;
        }
        public string Format()
            => Text;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(NumericLiteral<T> src)            
            => object.Equals(Data, src.Data);        

        public static NumericLiteral<T> Empty 
            => new NumericLiteral<T>(string.Empty, default, string.Empty, NBK.None);       
    }
}