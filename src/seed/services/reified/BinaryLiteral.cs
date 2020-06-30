//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using API = BinaryLiterals;

    /// <summary>
    /// Defines a base2 literal via text and a boxed value; for the literal to be valid,
    /// the text, when parsed, must yield a value equivalent to the boxed value
    /// </summary>
    public readonly struct BinaryLiteral : ILiteral<BinaryLiteral>
    {                                           
        /// <summary>
        /// The literal name
        /// </summary>
        public string Name {get;}
        
        /// <summary>
        /// The literal value
        /// </summary>
        public object Data {get;}
        
        /// <summary>
        /// Text that represents the boxed value
        /// </summary>
        public string Text {get;}

        [MethodImpl(Inline)]
        public BinaryLiteral(string name, object value, string text)
        {
            Name = name;
            Data = value;
            Text = text;
        }
        
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.empty(Name) && text.empty(Text);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !text.empty(Name) && !text.empty(Text) && Data != null;
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

        [MethodImpl(Inline)]
        public bool Equals(BinaryLiteral src)
            => API.eq(this, src);

        public static BinaryLiteral Empty   
            => new BinaryLiteral(string.Empty, 0, string.Empty);         
    }
}