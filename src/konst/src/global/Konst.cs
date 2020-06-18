//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public readonly partial struct Konst
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        public const MethodImplOptions NotInline = MethodImplOptions.NoInlining;

        public const MethodImplOptions Suboptimal = MethodImplOptions.NoOptimization;

        public const string Kernel32 = "kernel32.dll";

        /// <summary>
        /// The empty type
        /// </summary>
        public static Type TEmpty => typeof(void);

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
        public const string EmptyString = "";

        /// <summary>
        /// What else could this be?
        /// </summary>
        public const string Space = " ";

        public const FileWriteMode Overwrite = FileWriteMode.Overwrite;

        public const FileWriteMode Append = FileWriteMode.Append;

        public const byte AsciNone = (byte)AsciCharCode.Null;

        public const int NotFound = -1;


        [MethodImpl(Inline)]
        internal static ReadOnlySpan<T> transform<T>(ReadOnlySpan<byte> src)
            where T : unmanaged
                => MemoryMarshal.Cast<byte,T>(MemoryMarshal.CreateSpan(ref MemoryMarshal.GetReference(src), src.Length));

    }
}