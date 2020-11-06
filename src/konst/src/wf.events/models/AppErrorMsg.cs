//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using System.Reflection;

    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    [ApiHost(ApiNames.AppErrorMsg, true)]
    public static class AppErrorMsg
    {
        [Op]
        static AppMsg Fail(string msg, string caller, string file, int? line)
            => AppMsg.define($"{msg} {caller} {line} {file}", LogLevel.Error);

        [Op]
        static AppMsg Fail(string msg)
            => AppMsg.define(msg, LogLevel.Error);

        [Op]
        public static AppMsg Unanticipated(Exception e)
            => AppMsg.define(e?.ToString() ??"Heh?", LogLevel.Error);

        [Op]
        public static AppMsg NotEqual(object lhs, object rhs)
            => Fail($"Equality failure: {lhs} != {rhs}");

        [Op]
        public static AppMsg Equal(object lhs, object rhs)
            => Fail($"Non-equality failure: {lhs} == {rhs}");

        [Op]
        public static AppMsg FeatureUnsupported(object feature, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Fail($"Unsupported: {feature}", caller, file, line);

        [Op]
        public static AppMsg KindUnsupported<T>(T kind, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : Enum
                => Fail($"{typeof(T).Name}.{kind} not supported", caller, file, line);

        [Op]
        public static AppMsg TypeUnsupported(Type t, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Fail($"Type {t.Name} is not supported in the current context", caller, file, line);

        [Op]
        public static AppMsg KindOpUnsupported<S,T>(S src, T dst, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where S : Enum
            where T : Enum
                => Fail($"Operation {src} => {dst} not supported", caller, file, line);

        [Op]
        public static AppMsg NotEqual(object lhs, object rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Fail($"Equality failure: {lhs} != {rhs} {caller} {line} {file}", caller, file, line);

        [Op]
        public static AppMsg NotClose(float lhs, float rhs, float err, float tolerance, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Fail($"Approximate equality failure: relerr({lhs},{rhs}) = {err} > {tolerance}", caller, file, line) ;

        [Op]
        public static AppMsg NotClose(double lhs, double rhs, double err, double tolerance, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Fail($"Approximate equality failure: relerr({lhs},{rhs}) = {err} > {tolerance}",  caller, file, line) ;

        [Op]
        public static AppMsg Equal(object lhs, object rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Fail($"Non-equality failure: {lhs} == {rhs}", caller, file, line) ;

        [Op]
        public static AppMsg NotLessThan(object lhs, object rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Fail($"Not less than failure: !({lhs} < {rhs})", caller, file, line) ;

        [Op]
        public static AppMsg NotGreaterThan(object lhs, object rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Fail($"Not greater than failure: !({lhs} > {rhs})", caller, file, line) ;

        [Op]
        public static AppMsg NotGreaterThanOrEqual(object lhs, object rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Fail($"!({lhs} >= {rhs})", caller, file, line) ;

        [Op]
        public static AppMsg NotLessThanOrEqual(object lhs, object rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Fail($"!({lhs} <= {rhs})", caller, file, line) ;

        [Op]
        public static AppMsg ItemsNotEqual(int index, object lhs, object rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Fail($"Equality failure: lhs[{index}] = {lhs} != rhs[{index}] = {rhs}", caller, file, line);

        [Op]
        public static AppMsg NotNonzero([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Fail($"Value is not nonzero", caller, file, line);

        [Op]
        public static AppMsg NotTrue(string msg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Fail($"{msg ?? "The source value is not true"}", caller, file, line);

        [Op]
        public static AppMsg NotFalse(string msg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Fail($"{msg ?? "The source value is is not false"}", caller, file, line);

        [Op]
        public static AppMsg NotImplemented([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Fail($"{"The implementation does not exist"}", caller, file, line);

        [Op]
        public static AppMsg CountMismatch(int lhs, int rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Fail($"Count mismatch: {lhs} != {rhs}", caller, file, line);

        [Op]
        public static AppMsg EmptySourceSpan([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Fail($"The source span was empty", caller, file, line);

        [Op]
        public static AppMsg NonGenericMethod(MethodInfo t, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Fail($"The method {t.Name} is nongeneric", caller, file, line);

        [Op]
        public static AppMsg GenericMethod(MethodInfo t, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Fail($"The method {t.Name} is generic", caller, file, line);

        [Op]
        public static AppMsg LengthMismatch(int lhs, int rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Fail($"Length mismatch: {lhs} != {rhs}", caller, file, line);

        [Op]
        public static AppMsg InvariantFailure(object description, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Fail(description?.ToString() ?? "An required invariant was unsatisfied", caller,file,line);

        [Op]
        public static AppMsg InvariantFailure([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Fail(string.Empty, caller, file, line);

        [Op]
        public static AppMsg NotBetween<T>(T x, T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Fail($"The source value {x} is not between {lhs} and {rhs}", caller, file, line);

        [Op]
        public static AppMsg IndexOutOfRange(int index, int min, int max, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Fail($"The index {index} is not between {min} and {max}", caller, file, line);

        [Op]
        public static AppMsg TooManyBytes(int requested, int available, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Fail($"The number of bytes, {requested} exceeds the maximum available, {available}", caller, file, line);

        [Op]
        public static AppMsg FileDoesNotExist(FilePath path, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Fail($"The file {path} does not exist", caller, file, line);
    }
}