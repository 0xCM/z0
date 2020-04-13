//-----------------------------------------------------------------------------
// CPrimalyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;
    
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public static class AppErrorMsg
    {
        static AppMsg Fail(string msg, string caller, string file, int? line)
            => AppMsg.NoCaller($"{msg} {caller} {line} {file}", AppMsgKind.Error);

        static AppMsg Fail(string msg)
            => AppMsg.NoCaller(msg, AppMsgKind.Error);
        
        public static AppMsg Unanticipated(Exception e)
            => AppMsg.NoCaller(e?.ToString() ??"Heh?", AppMsgKind.Error);

        public static AppMsg NotEqual(object lhs, object rhs)
            => Fail($"Equality failure: {lhs} != {rhs}");

        public static AppMsg Equal(object lhs, object rhs)
            => Fail($"Non-equality failure: {lhs} == {rhs}");

        public static AppMsg FeatureUnsupported(object feature, string caller, string file, int? line)
            => Fail($"Unsupported: {feature}", caller, file, line);
        
        public static AppMsg KindUnsupported<T>(T kind, string caller, string file, int? line)
            where T : Enum
                => Fail($"{typeof(T).Name}.{kind} not supported", caller, file, line);
     
        public static AppMsg TypeUnsupported(Type t, string caller, string file, int? line)
            => Fail($"Type {t.Name} is not supported in the current context", caller, file, line);
        
        public static AppMsg KindOpUnsupported<S,T>(S src, T dst, string caller, string file, int? line)
            where S : Enum
            where T : Enum
                => Fail($"Operation {src} => {dst} not supported", caller, file, line);
        
        public static AppMsg NotEqual(object lhs, object rhs, string caller, string file, int? line)
            => Fail($"Equality failure: {lhs} != {rhs} {caller} {line} {file}", caller, file, line);

        public static AppMsg NotClose(float lhs, float rhs, float err, float tolerance, string caller, string file, int? line)
            => Fail($"Approximate equality failure: relerr({lhs},{rhs}) = {err} > {tolerance}", caller, file, line) ;

        public static AppMsg NotClose(double lhs, double rhs, double err, double tolerance, string caller, string file, int? line)
            => Fail($"Approximate equality failure: relerr({lhs},{rhs}) = {err} > {tolerance}",  caller, file, line) ;

        public static AppMsg Equal(object lhs, object rhs, string caller, string file, int? line)
            => Fail($"Non-equality failure: {lhs} == {rhs}", caller, file, line) ;

        public static AppMsg NotLessThan(object lhs, object rhs, string caller, string file, int? line)
            => Fail($"Not less than failure: !({lhs} < {rhs})", caller, file, line) ;

        public static AppMsg NotGreaterThan(object lhs, object rhs, string caller, string file, int? line)
            => Fail($"Not greater than failure: !({lhs} > {rhs})", caller, file, line) ;

        public static AppMsg NotGreaterThanOrEqual(object lhs, object rhs, string caller, string file, int? line)
            => Fail($"!({lhs} >= {rhs})", caller, file, line) ;

        public static AppMsg NotLessThanOrEqual(object lhs, object rhs, string caller, string file, int? line)
            => Fail($"!({lhs} <= {rhs})", caller, file, line) ;

        public static AppMsg ItemsNotEqual(int index, object lhs, object rhs, string caller, string file, int? line)
            => Fail($"Equality failure: lhs[{index}] = {lhs} != rhs[{index}] = {rhs}", caller, file, line);
        public static AppMsg NotNonzero(string caller, string file, int? line)
            => Fail($"Value is not nonzero", caller, file, line);        
        
        public static AppMsg NotTrue(string msg, string caller, string file, int? line)
            => Fail($"{msg ?? "The source value is not true"}", caller, file, line);

        public static AppMsg NotFalse(string msg, string caller, string file, int? line)
            => Fail($"{msg ?? "The source value is is not false"}", caller, file, line);
        public static AppMsg CountMismatch(int lhs, int rhs, string caller, string file, int? line)
            => Fail($"Count mismatch: {lhs} != {rhs}", caller, file, line);
        
        public static AppMsg EmptySourceSpan(string caller, string file, int? line)
            => Fail($"The source span was empty", caller, file, line);

        public static AppMsg NonGenericMethod(MethodInfo t, string caller, string file, int? line)
            => Fail($"The method {t.Name} is nongeneric", caller, file, line);

        public static AppMsg GenericMethod(MethodInfo t, string caller, string file, int? line)
            => Fail($"The method {t.Name} is generic", caller, file, line);

        public static AppMsg LengthMismatch(int lhs, int rhs, string caller, string file, int? line)
            => Fail($"Length mismatch: {lhs} != {rhs}", caller, file, line);

        public static AppMsg InvariantFailure(object description, string caller, string file, int? line)
            => Fail(description?.ToString() ?? "An required invariant was unsatisfied", caller,file,line);

        public static AppMsg InvariantFailure(string caller, string file, int? line)
            => Fail(string.Empty, caller, file, line);
                
        public static AppMsg NotBetween<T>(T x, T lhs, T rhs, string caller, string file, int? line)
            => Fail($"The source value {x} is not between {lhs} and {rhs}", caller, file, line);
        
        public static AppMsg IndexOutOfRange(int index, int min, int max, string caller, string file, int? line)
            => Fail($"The index {index} is not between {min} and {max}", caller, file, line);

        public static AppMsg TooManyBytes(int requested, int available, string caller, string file, int? line)
            => Fail($"The number of bytes, {requested} exceeds the maximum available, {available}", caller, file, line);
    
        public static AppMsg FileDoesNotExist(FilePath path, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)    
            => Fail($"The file {path} does not exist", caller, file, line);
    }
}