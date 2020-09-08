//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    using api = Literals;

    /// <summary>
    /// Defines a base2 literal via text and a boxed value; for the literal to be valid,
    /// the text, when parsed, must yield a value equivalent to the boxed value
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
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
            get => api.empty(this);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => api.nonempty(this);
        }

        public BinaryLiteral Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }


        [MethodImpl(Inline)]
        public string Format()
             => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(BinaryLiteral src)
            => api.eq(this,src);

        public static BinaryLiteral Empty
            => new BinaryLiteral(string.Empty, 0, string.Empty);

        string ILiteral.Name
            => Name;

        object ILiteral.Data
            => Data;

        string ILiteral.Text
            => Text;
    }
}