//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public readonly struct Errors
    {
        [Op]
        public static void @throw(string msg)
            => throw new Exception(msg);

        [Op]
        public static void @throw(string msg, string caller, int? line, string path)
            => throw new Exception(string.Format("{0}:{1} {2} {3}",msg, caller, line, path));


        public static T @throw<T>(object msg)
            => throw new Exception(msg?.ToString() ?? EmptyString);

        [Op]
        public static void @throw(Exception e)
            => throw e;

        [Op]
        public static void @throw(object e)
            => throw new Exception($"{e}");

        [Op]
        public static void @throw(Func<string> f)
            => throw new Exception(f());

        public static T @throw<T>(Exception e)
            => throw e;

        [Op]
        public static void ThrowArgNull(object arg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Errors.@throw(ArgNull(arg,caller,file,line));

        [Op]
        public static void ThrowBadSize(int expect, int actual, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Errors.@throw(new Exception($"The size {actual} is not aligned with {expect}:{FormatCallsite(caller,file,line)}"));


        const string Unknown = "???";

        const int UnknownInt = -1;

        [Op]
        static ArgumentNullException ArgNull(object arg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new ArgumentNullException((arg?.ToString() ?? string.Empty) + FormatCallsite(caller, file,line));

        [MethodImpl(Inline), Op]
        static string FormatCallsite(string caller, string file, int? line)
            => $"line {line ?? UnknownInt}, member {caller ?? Unknown} in file {file ?? Unknown}";
    }
}