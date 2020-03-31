//-----------------------------------------------------------------------------
// CPrimalyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using System.Runtime.Serialization;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Reflection;

    using static Components;

    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;
    
    public static class AppErrors
    {        
        const string Unknown = "???";
        
        const int UnknownInt = -1;

        [MethodImpl(Inline)]
        public static string FormatCallsite(string caller, string file, int? line)
            => $"line {line ?? UnknownInt}, member {caller ?? Unknown} in file {file ?? Unknown}";

        public static void Throw(object reason, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw AppException.Define(reason, caller,file,line);

        public static void Throw(AppMsg msg)
            => throw AppException.Define(msg);

        public static AppException InvariantFailure(object description, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(AppErrorMsg.InvariantFailure(description, caller, file, line));

        public static void ThrowInvariantFailure(object description, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw InvariantFailure(description, caller, file, line);

        public static void ThrowIfFalse(bool test, object msg = null, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            if(!test)
                ThrowInvariantFailure(msg, caller, file, line);
        }

        public static AppException FeatureUnsupported(object feature, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(AppErrorMsg.FeatureUnsupported(feature, caller, file, line));

        public static AppException DuplicateKeys(IEnumerable<object> keys, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(AppMsg.Error($"Duplicate keys were detected {keys.FormatList()}",  caller,file, line));
        
        public static void ThrowFeatureUnsupported(string feature, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw FeatureUnsupported(feature, caller, file, line);

        public static AppException NotEqual(object lhs, object rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(AppErrorMsg.NotEqual(lhs,rhs,caller,file,line));

        public static void ThrowNotEqual<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw NotEqual(lhs,rhs,caller,file,line);

        public static T ThrowNotEqualNoCaller<T>(T lhs, T rhs)
            => throw NotEqual(lhs,rhs,null,null,null);        

        public static void ThrowNotEqual<T>(T lhs, T rhs, AppMsg msg)
            => throw AppException.Define(msg.WithPrependedContent($"Equality failure, {lhs} != {rhs}:"));

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

        public static AppException CountMismatch(int lhs, int rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(AppErrorMsg.CountMismatch(lhs,rhs,caller,file,line));

        public static void ThrowCountMismatch(int lhs, int rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw CountMismatch(lhs,rhs, caller,file,line);

        public static AppException LengthMismatch(int lhs, int rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(AppErrorMsg.LengthMismatch(lhs,rhs,caller,file,line));

        public static AppException EmptySourceSpan([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(AppErrorMsg.EmptySourceSpan(caller,file,line));

        public static AppException NonGenericMethod(MethodInfo method, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(AppErrorMsg.NonGenericMethod(method,caller,file,line));

        public static AppException GenericMethod(MethodInfo method, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(AppErrorMsg.GenericMethod(method,caller,file,line));

        public static AppException KindUnsupported<T>(T kind, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : Enum
                => AppException.Define(AppErrorMsg.KindUnsupported(kind, caller, file, line));

        public static AppException TypeUnsupported(Type t, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(AppErrorMsg.TypeUnsupported(t, caller, file, line));  

        public static AppException TypeUnsupported<T>([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => TypeUnsupported(typeof(T), caller, file, line);

        public static AppException FileDoesNotExist(FilePath path, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(AppErrorMsg.FileDoesNotExist(path, caller, file, line));

        public static AppException KindOpUnsupported<S,T>(S src, T dst, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where S : Enum
            where T : Enum
                => AppException.Define(AppErrorMsg.KindOpUnsupported(src,dst, caller, file, line));

        public static IndexOutOfRangeException TooManyBytes(int requested, int available, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new IndexOutOfRangeException(AppErrorMsg.TooManyBytes(requested, available, caller, file, line).ToString());

        public static IndexOutOfRangeException IndexOutOfRange(int index, int min, int max, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new IndexOutOfRangeException(AppErrorMsg.IndexOutOfRange(index, min, max, caller, file, line).ToString());

        public static IndexOutOfRangeException IndexOutOfRange<T>(T value, T min, T max, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new IndexOutOfRangeException($"Value {value} is not between {min} and {max}: line {line}, member {caller} in file {file}");

        public static void ThrowTooShort(int dstLen, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw new IndexOutOfRangeException($"The target length {dstLen} is tooShort:{FormatCallsite(caller,file,line)}");

        public static void ThrowOutOfRange<T>(int index, int min, int max, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw IndexOutOfRange(index, min, max, caller, file, line);
        
        public static void ThrowOutOfRange<T>(T value, T min, T max, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw IndexOutOfRange(value,min,max,caller,file,line);

        public static AppException NoValue<T>([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define($"A value of type {typeof(T).Name} was expected but does not exist", caller,file,line);

        public static ArgumentException BadArg(object arg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new ArgumentException((arg?.ToString() ?? string.Empty) + FormatCallsite(caller, file,line));
        
        public static void ThrowBadArg(object arg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw BadArg(arg,caller,file,line);

        public static ArgumentNullException ArgNull(object arg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new ArgumentNullException((arg?.ToString() ?? string.Empty) + FormatCallsite(caller, file,line));
        
        public static void ThrowArgNull(object arg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw ArgNull(arg,caller,file,line);

        public static void ThrowBadSize(int expect, int actual, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw new Exception($"The size {actual} is not aligned with {expect}:{FormatCallsite(caller,file,line)}");
    }
}
