//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct BinaryLiteral
    {                                            
        [MethodImpl(Inline)]
        public static BinaryLiteral Define(string name, object value, string text)
            => new BinaryLiteral(name,value,text);

        [MethodImpl(Inline)]
        public static BinaryLiteral<T> Define<T>(string name, T value, string text)
            where T : unmanaged
                => new BinaryLiteral<T>(name,value,text);

        [MethodImpl(Inline)]
        public BinaryLiteral(string name, object value, string text)
        {
            this.Name = name;
            this.Value = value;
            this.Text = text;
        }

        public readonly string Name;

        public readonly object Value;
        
        public readonly string Text;

        public NumericKind Kind 
        {
            [MethodImpl(Inline)]
            get => Value?.GetType()?.NumericKind() ?? NumericKind.None;
        }

        public override string ToString()
            => this.Format();
    }

    public readonly struct BinaryLiteral<T>
        where T : unmanaged
    {                
        [MethodImpl(Inline)]
        public BinaryLiteral(string name, T value, string text)
        {
            this.Name = name;
            this.Value = value;
            this.Text = text;
        }

        public readonly string Name;
        
        public readonly T Value;

        public readonly string Text;
        
        public NumericKind Kind 
        {
            [MethodImpl(Inline)]
            get => NumericTypes.kind<T>();
        }

        public override string ToString()
            => this.Format();
    }
}