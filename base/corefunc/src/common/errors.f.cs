//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;
using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Defines an exception indicating that there is no operation associated with a specified kind
    /// </summary>
    /// <param name="kind">The enum type</param>
    /// <typeparam name="T">The enumeration type</typeparam>
    public static AppException unsupported<T>(T kind)
        where T : Enum
            => Errors.KindUnsupported(kind);
    
    public static AppException unsupported<T>([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        => Errors.TypeUnsupported(typeof(T), caller,file, line);

    public static T typefail<T>([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        => throw Errors.TypeUnsupported(typeof(T), caller,file, line);

    public static AppException unsupported(Type t, [Caller] string caller = null,  [File] string file = null, [Line] int? line = null)
        => Errors.TypeUnsupported(t, caller,file, line);

    public static AppException unsupported<S,T>(S src, T dst, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        where T : Enum
        where S : Enum
            => Errors.KindOpUnsupported(src, dst, caller, file, line);
    
    public static NotSupportedException unsupported(string feature, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        => new NotSupportedException(ErrorMessages.FeatureUnsupported(feature, caller, file, line).ToString());
    
    public static IndexOutOfRangeException outOfRange(int index, int min, int max, [Caller] string caller = null, [File] string file = null,  [Line] int? line = null)
            => Errors.OutOfRange(index,min,max, caller, file, line);
    public static ArgumentException badarg(string name, object value, [Caller] string caller = null, [File] string file = null,  [Line] int? line = null)
            => new ArgumentException($"An invalid argument {name} = {value}  was specified");    
    
    public static bool require(bool value, string info = null, [Caller] string caller = null, [File] string file = null,  [Line] int? line = null)
            =>  value ? true : throw new AppException(AppMsg.Define($"Invariant failure: {info}", SeverityLevel.Error, caller, file, line));    
    
    [MethodImpl(Inline)]
    public static bool demand(bool value, ReadOnlySpan<char> reason = default)
        => value ? true : Errors.ThrowInvariantFailure(reason.IsEmpty ? string.Empty : reason.ToString());
}