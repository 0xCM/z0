//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    [ApiHost]
    public static partial class AppErrors
    {
        const string Delimiter = " | ";

        /// <summary>
        /// Creates an error event
        /// </summary>
        /// <param name="content">The event content</param>
        public static AppError<T> define<T>(string source, T content)
            => new AppError<T>(EventId.define(nameof(AppError<T>), source), content);

        public static AppException missing([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(AppErrorMsg.NotImplemented(caller,file,line));

        public static string neq<T>(T lhs, T rhs)
             => string.Concat($"The operands are not equal", Delimiter, $"{lhs} != {rhs}");

        public static string neq<T>(T lhs, T rhs, string caller, string file, int? line)
             => string.Concat(neq(lhs,rhs), Delimiter, AppMsg.source(caller,file,line));

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static string NotTrue<T>(T src)
            => string.Concat("Predicate evaluation failed", Delimiter, src);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static string NotTrue<T>(T src, string caller, string file, int? line)
             => string.Concat(NotTrue(src), Delimiter, AppMsg.source(caller,file,line));

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static AppException nonvalued<T>([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define($"A value of type {typeof(T).Name} was expected but does not exist", caller,file,line);

        const string Unknown = "???";

        const int UnknownInt = -1;

        [MethodImpl(Inline), Op]
        public static string FormatCallsite(string caller, string file, int? line)
            => $"line {line ?? UnknownInt}, member {caller ?? Unknown} in file {file ?? Unknown}";

        public static void Throw(object reason, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw AppException.Define(reason, caller,file,line);

        public static void Throw(AppMsg msg)
            => throw AppException.Define(msg);

        public static AppException Equal(object lhs, object rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(AppErrorMsg.Equal(lhs,rhs,caller,file,line));

        public static AppException NotLessThan(object lhs, object rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(AppErrorMsg.NotLessThan(lhs,rhs,caller,file,line));

        public static AppException ItemsNotEqual(int index, object lhs, object rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(AppErrorMsg.ItemsNotEqual(index, lhs,rhs,caller,file,line));

        public static AppException NotNonzero([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(AppErrorMsg.NotNonzero(caller,file,line));

        public static AppException NotTrue(string msg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(AppErrorMsg.NotTrue(msg,caller,file,line));

        public static AppException NotFalse(string msg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(AppErrorMsg.NotFalse(msg,caller,file,line));

        public static AppException LengthMismatch(int lhs, int rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(AppErrorMsg.LengthMismatch(lhs,rhs,caller,file,line));

        public static AppException NonGenericMethod(MethodInfo method, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(AppErrorMsg.NonGenericMethod(method,caller,file,line));

        public static AppException GenericMethod(MethodInfo method, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(AppErrorMsg.GenericMethod(method,caller,file,line));

        public static AppException FileDoesNotExist(FilePath path, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(AppErrorMsg.FileDoesNotExist(path, caller, file, line));

        public static ArgumentException BadArg(object arg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new ArgumentException((arg?.ToString() ?? string.Empty) + FormatCallsite(caller, file,line));

        public static void ThrowBadArg(object arg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => sys.@throw(BadArg(arg,caller,file,line));

        public static ArgumentNullException ArgNull(object arg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new ArgumentNullException((arg?.ToString() ?? string.Empty) + FormatCallsite(caller, file,line));

        public static void ThrowArgNull(object arg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => sys.@throw(ArgNull(arg,caller,file,line));

        public static void ThrowBadSize(int expect, int actual, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => sys.@throw(new Exception($"The size {actual} is not aligned with {expect}:{FormatCallsite(caller,file,line)}"));
    }
}