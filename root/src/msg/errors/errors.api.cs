//-----------------------------------------------------------------------------
// CPrimalyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using System.Runtime.Serialization;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;
    
    public static class errors
    {        
        const string Unknown = "???";
        
        const int UnknownInt = -1;

        [MethodImpl(Inline)]
        public static string FormatCallsite(string caller, string file, int? line)
            => $"line {line ?? UnknownInt}, member {caller ?? Unknown} in file {file ?? Unknown}";

        public static AppException NotEqual(object lhs, object rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(messages.NotEqual(lhs,rhs,caller,file,line));

        public static AppException Equal(object lhs, object rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(messages.Equal(lhs,rhs,caller,file,line));

        public static AppException NotLessThan(object lhs, object rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(messages.NotLessThan(lhs,rhs,caller,file,line));

        public static AppException ItemsNotEqual(int index, object lhs, object rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(messages.ItemsNotEqual(index, lhs,rhs,caller,file,line));

        public static AppException NotNonzero([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(messages.NotNonzero(caller,file,line));
        
        public static AppException NotTrue(string msg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(messages.NotTrue(msg,caller,file,line));

        public static AppException NotFalse(string msg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(messages.NotFalse(msg,caller,file,line));

        public static AppException CountMismatch(int lhs, int rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(messages.CountMismatch(lhs,rhs,caller,file,line));

        public static AppException LengthMismatch(int lhs, int rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(messages.LengthMismatch(lhs,rhs,caller,file,line));

        public static AppException EmptySourceSpan([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(messages.EmptySourceSpan(caller,file,line));

        public static AppException NonGenericMethod(MethodInfo method, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(messages.NonGenericMethod(method,caller,file,line));

        public static AppException GenericMethod(MethodInfo method, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(messages.GenericMethod(method,caller,file,line));

        public static AppException KindUnsupported<T>(T kind, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : Enum
                => AppException.Define(messages.KindUnsupported(kind, caller, file, line));

        public static AppException TypeUnsupported(Type t, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
                => AppException.Define(messages.TypeUnsupported(t, caller, file, line));

        public static AppException FeatureUnsupported(string feature, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(messages.FeatureUnsupported(feature, caller, file, line));
        
        public static void ThrowFeatureUnsupported(string feature, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw FeatureUnsupported(feature, caller, file, line);
  
        public static AppException FileDoesNotExist(FilePath path, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(messages.FileDoesNotExist(path, caller, file, line));

        public static AppException KindOpUnsupported<S,T>(S src, T dst, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where S : Enum
            where T : Enum
                => AppException.Define(messages.KindOpUnsupported(src,dst, caller, file, line));

        public static IndexOutOfRangeException TooManyBytes(ByteSize requested, ByteSize available, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new IndexOutOfRangeException(messages.TooManyBytes(requested, available, caller, file, line).ToString());

        public static IndexOutOfRangeException OutOfRange(int index, int min, int max, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new IndexOutOfRangeException(messages.IndexOutOfRange(index,min,max, caller, file, line).ToString());

        public static IndexOutOfRangeException OutOfRange<T>(T value, T min, T max, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new IndexOutOfRangeException($"Value {value} is not between {min} and {max}: line {line}, member {caller} in file {file}");

        public static AppException NoValue<T>([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define($"A value of type {typeof(T).Name} was expected but does not exist", caller,file,line);

        public static T ThrowNotEqualInfo<T>(T lhs, T rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw AppException.Define(messages.NotEqual(lhs,rhs,caller,file,line));

        public static T ThrowNotEqual<T>(T lhs, T rhs)
            => throw AppException.Define(AppMsg.Define($"Equality failure, {lhs} != {rhs}", AppMsgKind.Error));

        public static T ThrowNotEqual<T>(T lhs, T rhs, AppMsg msg)
            => throw AppException.Define(msg.WithPrependedContent($"Equality failure, {lhs} != {rhs}:"));

        public static T ThrowArgException<A,T>(A arg)
            => throw new ArgumentNullException(arg?.ToString() ?? string.Empty);

        public static void Throw(string reason, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw AppException.Define(reason, caller,file,line);

        public static void Throw(AppMsg msg)
            => throw AppException.Define(msg);

        public static void ThrowInvariantFailure(string reason)
            => throw new Exception(reason);

        public static T ThrowOutOfRange<T>(int index, int min, int max, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw OutOfRange(index, min, max, caller, file, line);
        
        public static void ThrowOutOfRange<T>(T value, T min, T max, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw OutOfRange(value,min,max,caller,file,line);

        public static void ThrowTooShort(int dstLen, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw new IndexOutOfRangeException($"The target length {dstLen} is tooShort:{FormatCallsite(caller,file,line)}");

        public static void ThrowBadSize(int expect, int actual, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw new Exception($"The size {actual} is not aligned with {expect}:{FormatCallsite(caller,file,line)}");

        public static void ThrowCountMismatch(int lhs, int rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw CountMismatch(lhs,rhs, caller,file,line);

        public static void ThrowIfFalse(bool condition, string msg = null, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            if(!condition)
                throw new Exception($"{msg?? "Invariant Failure"}:{FormatCallsite(caller,file,line)}");
        }
    }
}
