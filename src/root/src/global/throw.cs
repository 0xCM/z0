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

    partial struct Root
    {
        [Op]
        public static void @throw(Exception e)
            => throw e;

        public static T @throw<T>(Exception e)
            => throw e;

        public static T @throw<T>([Caller] string caller = null, [Line] int? line = null, [File] string? path = null)
            => throw new Exception();

        public static NotSupportedException no<T>()
            => new NotSupportedException($"The type {typeof(T).Name} is not supported");

        public static NotSupportedException no(object msg)
            => new NotSupportedException(msg.ToString());

        public static T no<S,T>([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Unsupported.raise<S,T>(caller, file, line);

        [Op, Closures(UnsignedInts)]
        public static ArgumentException badarg<T>(T arg)
            => new ArgumentException(arg?.ToString() ?? "<null>");

        [Op]
        public static Exception DuplicateKeyException(IEnumerable<object> keys, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new Exception(string.Concat($"Duplicate keys were detected {string.Join(Chars.Comma, keys)}",  caller,file, line));
    }
}