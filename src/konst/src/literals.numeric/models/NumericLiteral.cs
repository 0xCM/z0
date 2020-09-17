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
    /// Defines a (boxed) numeric literal relative to a specified base
    /// </summary>
    public readonly struct NumericLiteral : INumericLiteral<NumericLiteral>
    {
        public readonly string Name;
        
        public readonly object Data;

        public readonly string Text;

        public readonly NBK Base;
        
        [MethodImpl(Inline)]
        public static NumericLiteral Base2(string Name, object Value, string Text)
            => new NumericLiteral(Name, Value, Text, NBK.Base2);

        [MethodImpl(Inline)]
        public static NumericLiteral Base10(string Name, object Value, string Text)
            => new NumericLiteral(Name, Value, Text, NBK.Base10);

        [MethodImpl(Inline)]
        public static NumericLiteral Base16(string Name, object Value, string Text)
            => new NumericLiteral(Name, Value, Text, NBK.Base16);

        [MethodImpl(Inline)]
        public static NumericLiteral Define(string Name, object Value, string Text, NBK NumericBase)
            => new NumericLiteral(Name,Value,Text,NumericBase);

        [MethodImpl(Inline)]
        public NumericLiteral(string name, object data, string text, NBK @base)
        {
            Name = name;
            Data = data ?? 0;
            Text = text ?? Data.ToString();
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
            get => Data != null && Data.GetType() != typeof(string);
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

        public NumericLiteral Zero
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
        public bool Equals(NumericLiteral src)            
            => object.Equals(Data, src.Data);        

        public static NumericLiteral Empty 
            => new NumericLiteral(EmptyString, EmptyString, EmptyString, 0);

        string ILiteral.Name 
            => Name;

        object ILiteral.Data 
            => Data;

        string ILiteral.Text 
            => Text;
    }
}