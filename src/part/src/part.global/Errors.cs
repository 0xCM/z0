//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    partial struct Part
    {
        public static NotSupportedException no<T>()
            => new NotSupportedException($"The type {typeof(T).Name} is not supported");

        public static NotSupportedException no()
            => new NotSupportedException();

        public static T no<S,T>([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Unsupported.raise<S,T>(caller, file, line);

        [Op, Closures(UnsignedInts)]
        public static ArgumentException badarg<T>(T arg)
            => new ArgumentException(arg?.ToString() ?? "<null>");

        [MethodImpl(Inline), Op]
        public static void ThrowEmptySpanError()
            => Errors.Throw($"The span, it is empty");

        [Op]
        public static Exception DuplicateKeyException(IEnumerable<object> keys, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new Exception(string.Concat($"Duplicate keys were detected {string.Join(Chars.Comma, keys)}",  caller,file, line));
    }
}