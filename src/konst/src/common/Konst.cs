//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Reflection;

    [ApiHost("api")]
    public readonly partial struct Konst
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        public const MethodImplOptions NotInline = MethodImplOptions.NoInlining;

        public const MethodImplOptions Suboptimal = MethodImplOptions.NoOptimization;

        public const string Kernel32 = "kernel32.dll";

        /// <summary>
        /// A type considered to be empty
        /// </summary>
        public static Type EmptyType => typeof(void);

        /// <summary>
        /// Uppercase letter classifier accessor
        /// </summary>
        public static UpperCased UpperCase => default;

        /// <summary>
        /// Lowercase letter classifier accessor
        /// </summary>
        public static LowerCased LowerCase => default;

        /// <summary>
        /// Letter classifier accessor
        /// </summary>
        public static Letter Letter => default;

        /// <summary>
        /// Number classifier accessor
        /// </summary>
        public static Number Number => default;

        /// <summary>
        /// An abbreviation for the ridiculously long "StringComparison.InvariantCultureIgnoreCase"
        /// </summary>
        public const StringComparison NoCase = StringComparison.InvariantCultureIgnoreCase;

        /// <summary>
        /// An abbreviation for the somewhat verbose "StringComparison.InvariantCulture"
        /// </summary>
        public const StringComparison Cased = StringComparison.InvariantCulture;

        public const char FilePathSep = '/';

        /// <summary>
        /// The number of bits to shift a field specifier left/right to reveal/specify the width of an identified field
        /// </summary>
        public const int WidthOffset = 16;

        /// <summary>
        /// The default delimiter to use when formatting structured text
        /// </summary>
        public const char FieldDelimiter = Chars.Pipe;

        /// <summary>
        /// What else could this be?
        /// </summary>
        public const string EmptyString = Zero.zS;

        /// <summary>
        /// What else could this be?
        /// </summary>
        public const char Space = ' ';

        /// <summary>
        /// The end-of-line escape sequence
        /// </summary>
        public const string Eol = Chars.Eol;

        /// <summary>
        /// The '{' character
        /// </summary>
        public const char RBrace = Chars.RBrace;

        /// <summary>
        /// The '}' character
        /// </summary>
        public const char LBrace = Chars.LBrace;

        /// <summary>
        /// The ':' character
        /// </summary>
        public const char Colon = Chars.Colon;

        /// <summary>
        /// The ':' character
        /// </summary>
        public const char Semicolon = Chars.Semicolon;

        /// <summary>
        /// Indicates that emitted content should overwrite whatever file content may exist
        /// </summary>
        public const FileWriteMode Overwrite = FileWriteMode.Overwrite;

        /// <summary>
        /// Indicates that emitted content should be appended to a file, rather than replacing a file
        /// </summary>
        public const FileWriteMode Append = FileWriteMode.Append;

        public const byte AsciNone = (byte)AsciCharCode.Null;

        /// <summary>
        /// Canonical return value for search operation that returns a nonnegative vaule upon succes
        /// </summary>
        public const int NotFound = -1;

        /// <summary>
        /// The "->" character sequence
        /// </summary>
        public const string AsciArrow = "->";

        /// <summary>
        /// The ":=" character sequence
        /// </summary>
        public const string Define = ":=";

        /// <summary>
        /// The " | " character sequence
        /// </summary>
        public const string SpacePipe = " | ";

        /// <summary>
        /// Species the base2 singleton representative
        /// </summary>
        public static Base2 base2 => default;

        /// <summary>
        /// Species the base8 singleton representative
        /// </summary>
        public static Base3 base3 => default;

        /// <summary>
        /// Species the base8 singleton representative
        /// </summary>
        public static Base8 base8 => default;

        /// <summary>
        /// Species the base10 singleton representative
        /// </summary>
        public static Base10 base10 => default;

        /// <summary>
        /// Species the base16 singleton representative
        /// </summary>
        public static Base16 base16 => default;

        public const OpacityKind Opaque = OpacityKind.Closure;

        public const string Connector = " -> ";

        public const ApiClassKind DataStructure = ApiClassKind.DataStructure;

        public const ApiClassKind DataSummary = ApiClassKind.DataSummary;

        public const ApiClassKind DataIndex = ApiClassKind.DataSummary;

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T zed<T>(T t = default)
            where T : unmanaged
                => Zero.zed(t);

        [MethodImpl(Inline)]
        internal static ReadOnlySpan<T> transform<T>(ReadOnlySpan<byte> src)
            where T : unmanaged
                => MemoryMarshal.Cast<byte,T>(MemoryMarshal.CreateSpan(ref MemoryMarshal.GetReference(src), src.Length));

        /// <summary>
        /// Populates a <see cref="NotSupportedException"/> complaining that a
        /// parametrically-identified type is not supported
        /// </summary>
        /// <typeparam name="T">The unsupported type</typeparam>
        [MethodImpl(Inline), Closures(AllNumeric)]
        public static NotSupportedException no<T>()
            => Unsupported.define<T>();

        [MethodImpl(Inline), Closures(AllNumeric)]
        public static T bad<T>()
            => Unsupported.raise<T>();

        public static T no<S,T>()
            => Unsupported.raise<T>($"The transformation {typeof(S).Name} -> {typeof(T).Name} is undefined");

        [MethodImpl(Inline), Op]
        public static void ThrowEmptySpanError()
            => sys.@throw($"The span, it is empty");

        [MethodImpl(Inline), Op]
        public static void ThrowDuplicated<K,V>(KeyedValue<K,V> kvp)
            => sys.@throw(new Exception($"The key {kvp.Key} for {kvp.Value} is not unique"));
    }

    public static partial class XTend
    {
    }
}