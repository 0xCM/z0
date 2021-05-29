//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    /// <summary>
    /// Defines a base2 literal via text and a boxed value; for the literal to be valid,
    /// the text, when parsed, must yield a value equivalent to the boxed value
    /// </summary>
    public readonly struct BinaryLiteral : ILiteral<BinaryLiteral>
    {
        /// <summary>
        /// The literal name
        /// </summary>
        public readonly string Name;

        /// <summary>
        /// The literal value
        /// </summary>
        public readonly object Data;

        /// <summary>
        /// Text that represents the boxed value
        /// </summary>
        public readonly string Text;

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
            get => blank(Name) && (blank(Text) || (Data == null));
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => nonempty(Name) && nonempty(Text) && Data != null;
        }

        public BinaryLiteral Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        [MethodImpl(Inline)]
        public string Format()
             => $"{Name}({Data}:{kind(this).Keyword()}) := " + RP.enquote(Text);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(BinaryLiteral src)
            => eq(this,src);

        string ILiteral.Name
            => Name;

        object ILiteral.Data
            => Data;

        string ILiteral.Text
            => Text;

        public static BinaryLiteral Empty
            => new BinaryLiteral(string.Empty, 0, string.Empty);

        /// <summary>
        /// Discerns the numeric kind of a specified binary literal
        /// </summary>
        /// <param name="src">The source literal</param>
        [MethodImpl(Inline), Op]
        static NumericKind kind(BinaryLiteral src)
            => src.Data?.GetType()?.NumericKind() ?? NumericKind.None;

        [MethodImpl(Inline), Op]
        static bool eq(BinaryLiteral x, BinaryLiteral y)
            => string.Equals(x.Text, y.Text)
            && object.Equals(x.Data, y.Data)
            && string.Equals(x.Name, y.Name);
    }
}