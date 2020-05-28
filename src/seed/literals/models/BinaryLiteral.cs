//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using API = Literati;

    public readonly struct BinaryLiteral : ITextual, INullaryKnown, INullary<BinaryLiteral>
    {                                   
        public static BinaryLiteral Empty   
            => new BinaryLiteral(string.Empty, 0, string.Empty);         
        
        public readonly string Name;

        public readonly object Value;
        
        public readonly string Text;

        [MethodImpl(Inline)]
        public BinaryLiteral(string name, object value, string text)
        {
            this.Name = name;
            this.Value = value;
            this.Text = text;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.empty(Name) && text.empty(Text);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !text.empty(Name) && !text.empty(Text) && Value != null;
        }

        public BinaryLiteral Zero
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