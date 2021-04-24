//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    [ApiHost("api"), LiteralProvider]
    public readonly partial struct Konst
    {
        public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        public const MethodImplOptions NotInline = MethodImplOptions.NoInlining;

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
        /// Populates a <see cref="NotSupportedException"/> complaining that a
        /// parametrically-identified type is not supported
        /// </summary>
        /// <typeparam name="T">The unsupported type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static NotSupportedException no<T>()
            => Unsupported.define<T>();

        public static NotSupportedException no()
            => new NotSupportedException();

        [Op, Closures(AllNumeric)]
        public static ArgumentException badarg<T>(T arg)
            => new ArgumentException(arg?.ToString() ?? "<null>");

        public static T no<S,T>([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Unsupported.raise<S,T>(caller, file, line);
    }
}