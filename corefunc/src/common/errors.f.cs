//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;

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
            => errors.KindUnsupported(kind);
    
    public static AppException unsupported<T>([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        => errors.TypeUnsupported(typeof(T), caller,file, line);

    public static AppException unsupported(Type t, [Caller] string caller = null,  [File] string file = null, [Line] int? line = null)
        => errors.TypeUnsupported(t, caller,file, line);

    public static AppException unsupported<S,T>(S src, T dst, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        where T : Enum
        where S : Enum
            => errors.KindOpUnsupported(src, dst, caller, file, line);    
    
    public static bool require(bool value, string info = null, [Caller] string caller = null, [File] string file = null,  [Line] int? line = null)
            =>  value ? true : throw new AppException(AppMsg.Define($"Invariant failure: {info}", AppMsgKind.Error, caller, file, line));        
}