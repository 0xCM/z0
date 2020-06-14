//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    using NBK = NumericBaseKind;
    
    /// <summary>
    /// Defines a (boxed) numeric literal relative to a specified base
    /// </summary>
    public readonly struct NumericLiteral : INumericLiteral<NumericLiteral>
    {
        public static NumericLiteral Empty 
            => new NumericLiteral(string.Empty, string.Empty, string.Empty, NBK.None);

        public string Name {get;}
        
        public object Data {get;}

        public string Text {get;}

        public NBK Base {get;}
        
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
        NumericLiteral(string Name, object Value, string Text, NBK NumericBase)
        {
            this.Name = Name;
            this.Data = Value ?? string.Empty;
            this.Text = Text ?? this.Data.ToString();
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
        
        /// <summary>
        /// The 8'th Mersene prime and the largest 32-bit prime
        /// </summary>
        /// <remarks>
        /// See https://en.wikipedia.org/wiki/2,147,483,647
        /// <remarks>
        const uint Mersene8 = 2147483647u;
    }
}