//-----------------------------------------------------------------------------
// CPrimalyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using System.Reflection;
    using System.Runtime.CompilerServices;
    
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public static class messages
    {
        public static AppMsg FeatureUnsupported(string feature, string caller, string file, int? line)
                => AppMsg.Define($"Unsupported: {feature}", AppMsgKind.Error, caller, file, line);
        public static AppMsg KindUnsupported<T>(T kind, string caller, string file, int? line)
            where T : Enum
                => AppMsg.Define($"{typeof(T).Name}.{kind} not supported", AppMsgKind.Error, caller, file, line);
        public static AppMsg TypeUnsupported(Type t, string caller, string file, int? line)
                => AppMsg.Define($"Type {t.Name} is not supported in the current context", AppMsgKind.Error, caller, file, line);
        public static AppMsg KindOpUnsupported<S,T>(S src, T dst, string caller, string file, int? line)
            where S : Enum
            where T : Enum
                => AppMsg.Define($"Operation {src} => {dst} not supported", AppMsgKind.Error, caller, file, line);

        public static AppMsg NotEqual(object lhs, object rhs, string caller, string file, int? line)
            => AppMsg.Define($"Equality failure: {lhs} != {rhs}", AppMsgKind.Error, caller, file, line) ;

        public static AppMsg NotClose(float lhs, float rhs, float err, float tolerance, string caller, string file, int? line)
            => AppMsg.Define($"Approximate equality failure: relerr({lhs},{rhs}) = {err} > {tolerance}", AppMsgKind.Error, caller, file, line) ;

        public static AppMsg NotClose(double lhs, double rhs, double err, double tolerance, string caller, string file, int? line)
            => AppMsg.Define($"Approximate equality failure: relerr({lhs},{rhs}) = {err} > {tolerance}", AppMsgKind.Error, caller, file, line) ;

        public static AppMsg Equal(object lhs, object rhs, string caller, string file, int? line)
            => AppMsg.Define($"{lhs} == {rhs}", AppMsgKind.Error, caller, file, line) ;

        public static AppMsg NotLessThan(object lhs, object rhs, string caller, string file, int? line)
            => AppMsg.Define($"Not less than failure: !({lhs} < {rhs})", AppMsgKind.Error, caller, file, line) ;

        public static AppMsg NotGreaterThan(object lhs, object rhs, string caller, string file, int? line)
            => AppMsg.Define($"Not greater than failure: !({lhs} > {rhs})", AppMsgKind.Error, caller, file, line) ;

        public static AppMsg NotGreaterThanOrEqual(object lhs, object rhs, string caller, string file, int? line)
            => AppMsg.Define($"!({lhs} >= {rhs})", AppMsgKind.Error, caller, file, line) ;

        public static AppMsg NotLessThanOrEqual(object lhs, object rhs, string caller, string file, int? line)
            => AppMsg.Define($"!({lhs} <= {rhs})", AppMsgKind.Error, caller, file, line) ;

        public static AppMsg ItemsNotEqual(int index, object lhs, object rhs, string caller, string file, int? line)
            => AppMsg.Define($"Equality failure: lhs[{index}] = {lhs} != rhs[{index}] = {rhs}", AppMsgKind.Error, caller, file, line);
        public static AppMsg NotNonzero(string caller, string file, int? line)
            => AppMsg.Define($"Value is not nonzero",  AppMsgKind.Error, caller, file, line);        
        
        public static AppMsg NotTrue(string msg, string caller, string file, int? line)
            => AppMsg.Define($"{msg ?? "The source value is not true"}", AppMsgKind.Error, caller, file, line);

        public static AppMsg NotFalse(string msg, string caller, string file, int? line)
            => AppMsg.Define($"{msg ?? "The source value is is not false"}", AppMsgKind.Error, caller, file, line);
        public static AppMsg CountMismatch(int lhs, int rhs, string caller, string file, int? line)
            => AppMsg.Define($"Count mismatch: {lhs} != {rhs}", AppMsgKind.Error, caller, file, line);
        
        public static AppMsg EmptySourceSpan(string caller, string file, int? line)
            => AppMsg.Define($"The source span was empty", AppMsgKind.Error, caller, file, line);

        public static AppMsg NonGenericMethod(MethodInfo t, string caller, string file, int? line)
            => AppMsg.Define($"The method {t.Name} is nongeneric", AppMsgKind.Error, caller, file, line);

        public static AppMsg GenericMethod(MethodInfo t, string caller, string file, int? line)
            => AppMsg.Define($"The method {t.Name} is generic", AppMsgKind.Error, caller, file, line);

        public static AppMsg LengthMismatch(int lhs, int rhs, string caller, string file, int? line)
            => AppMsg.Define($"Length mismatch: {lhs} != {rhs}", AppMsgKind.Error, caller, file, line);

        public static AppMsg NotBetween<T>(T x, T lhs, T rhs, string caller, string file, int? line)
            => AppMsg.Define($"The source value {x} is not between {lhs} and {rhs}", AppMsgKind.Error, caller, file, line);

        public static AppMsg IndexOutOfRange(int index, int min, int max, string caller, string file, int? line)
            => AppMsg.Define($"The index {index} is not between {min} and {max}", AppMsgKind.Error, caller, file, line);

        public static AppMsg TooManyBytes(ByteSize requested, ByteSize available, string caller, string file, int? line)
            => AppMsg.Define($"The number of bytes, {requested} exceeds the maximum available, {available}", AppMsgKind.Error, caller, file, line);

        public static AppMsg Unanticipated(Exception e, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppMsg.Define(e?.ToString() ??"Heh?", AppMsgKind.Error, caller, file, line);
    
        public static AppMsg FileDoesNotExist(FilePath path, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)    
            => AppMsg.Define($"The file {path} does not exist", AppMsgKind.Error, caller, file, line);
    }
}