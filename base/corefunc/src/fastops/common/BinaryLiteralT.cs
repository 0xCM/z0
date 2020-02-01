//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

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
            get => NumericType.kind<T>();
        }

        public string Format() => $"{Name}({Value}:{Kind.Keyword()}) := " + enquote(Text);

        public override string ToString()
            => Format();
    }

}