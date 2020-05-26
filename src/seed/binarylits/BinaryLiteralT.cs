//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using API = BinaryLiterals;

    public readonly struct BinaryLiteral<T> : ITextual, INullaryKnown, INullary<BinaryLiteral<T>>
        where T : unmanaged
    {                
        public static BinaryLiteral<T> Empty 
            => new BinaryLiteral<T>(string.Empty,default, string.Empty);                 
        
        public readonly string Name;
        
        public readonly T Value;

        public readonly string Text;
        
        [MethodImpl(Inline)]
        public BinaryLiteral(string name, T value, string text)
        {
            this.Name = name;
            this.Value = value;
            this.Text = text;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.empty(Name) && text.empty(Text) && Value.Equals(default);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public BinaryLiteral<T> Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        [MethodImpl(Inline)]
        public string Format()
            => API.format(this);

        public override string ToString()
            => Format();
    }
}