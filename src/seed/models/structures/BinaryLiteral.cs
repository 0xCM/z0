//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

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
            get => BinaryLiteral.empty(this);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => BinaryLiteral.nonempty(this);
        }

        public BinaryLiteral Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }
        

        [MethodImpl(Inline)]
        public string Format()
             => format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(BinaryLiteral src)
            => eq(this,src);

        public static BinaryLiteral Empty   
            => new BinaryLiteral(string.Empty, 0, string.Empty);

        string ILiteral.Name 
            => Name;

        object ILiteral.Data 
            => Data;

        string ILiteral.Text 
            => Text;

        [MethodImpl(Inline)]
        public static bool eq(in BinaryLiteral x, in BinaryLiteral y)
            => string.Equals(x.Text, y.Text) 
            && object.Equals(x.Data, y.Data) 
            && string.Equals(x.Name, y.Name);

        [MethodImpl(Inline)]
        public static bool eq<T>(in BinaryLiteral<T> x, in BinaryLiteral<T> y)
            where T : unmanaged
                => string.Equals(x.Text, y.Text) 
                && object.Equals(x.Data, y.Data) 
                && string.Equals(x.Name, y.Name);

        [MethodImpl(Inline)]
        public static NumericKind kind(in BinaryLiteral src)
            => src.Data?.GetType()?.NumericKind() ?? NumericKind.None;

        /// <summary>
        /// Discerns the numeric kind of a specified binary literal
        /// </summary>
        /// <param name="src">The source literal</param>
        [MethodImpl(Inline)]
        public static NumericKind kind<T>(in BinaryLiteral<T> src)
            where T : unmanaged
                => NumericKinds.kind<T>();

        public static string format(in BinaryLiteral src) 
            => $"{src.Name}({src.Data}:{kind(src).Keyword()}) := " + text.enquote(src.Text);

        public static string format<T>(in BinaryLiteral<T> src) 
            where T : unmanaged
                => $"{src.Name}({src.Data}:{kind(src).Keyword()}) := " + text.enquote(src.Text);

        [MethodImpl(Inline)]
        public static bool empty(in BinaryLiteral src)
            => sys.empty(src.Name) && sys.empty(src.Text) && src.Data is null;

        [MethodImpl(Inline)]
        public static bool empty<T>(in BinaryLiteral<T> src)
            where T : unmanaged
                => sys.empty(src.Name) && sys.empty(src.Text) && src.Data.Equals(default);
        
        [MethodImpl(Inline)]
        public static bool nonempty(in BinaryLiteral src)
            => !sys.empty(src.Name) && !sys.empty(src.Text) && src.Data != null;

        [MethodImpl(Inline)]
        public static bool nonempty<T>(in BinaryLiteral<T> src)
            where T : unmanaged
                => !sys.empty(src.Name) && !sys.empty(src.Text) && !src.Data.Equals(default);
    }
}