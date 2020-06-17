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
    public readonly struct NumericLiteral<T> : INumericLiteral<NumericLiteral<T>,T>
        where T : unmanaged
    {
        public static NumericLiteral<T> Empty 
            => new NumericLiteral<T>(string.Empty, default, string.Empty, NBK.None);

        public string Name {get;}
        
        public T Data {get;}

        public string Text {get;}

        public NBK Base {get;}
        
        [MethodImpl(Inline)]
        public static NumericLiteral<T> Base2(string Name, T Value, string Text)
            => new NumericLiteral<T>(Name, Value, Text, NBK.Base2);

        [MethodImpl(Inline)]
        public static NumericLiteral<T> Base10(string Name, T Value, string Text)
            => new NumericLiteral<T>(Name, Value, Text, NBK.Base10);

        [MethodImpl(Inline)]
        public static NumericLiteral<T> Base16(string Name, T Value, string Text)
            => new NumericLiteral<T>(Name, Value, Text, NBK.Base16);

        [MethodImpl(Inline)]
        public static NumericLiteral<T> Define(string Name, T Value, string Text, NBK NumericBase)
            => new NumericLiteral<T>(Name,Value,Text,NumericBase);

        [MethodImpl(Inline)]
        internal NumericLiteral(string name, T data, string Text, NBK NumericBase)
        {
            this.Name = name;
            this.Data = data;
            this.Text = Text ?? data.ToString();
            this.Base = NumericBase;
        }        

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.empty(Text);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !text.empty(Text);
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
    }
}