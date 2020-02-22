//-----------------------------------------------------------------------------
// CPrimalyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    /// <summary>
    /// Defines a concise api for communicating common error conditions
    /// </summary>
    public static class Errors
    {
        const string Unknown = "???";
        
        const int UnknownInt = -1;

        [MethodImpl(Inline)]
        public static string FormatCallsite(string caller, string file, int? line)
            => $"line {line ?? UnknownInt}, member {caller ?? Unknown} in file {file ?? Unknown}";

        [MethodImpl(NotInline)]
        public static Exception CountMismatch(int lhs, int rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new Exception($"Count mismatch, {lhs} != {rhs}:{FormatCallsite(caller,file,line)}");

        [MethodImpl(NotInline)]
        public static Exception OutOfRange<T>(T value, T min, T max, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new Exception($"Value {value} is not between {min} and {max}:{FormatCallsite(caller,file,line)}");
        
        [MethodImpl(NotInline)]
        public static void ThrowCountMismatch(int lhs, int rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw CountMismatch(lhs,rhs, caller,file,line);

        [MethodImpl(NotInline)]
        public static void ThrowOutOfRange<T>(T value, T min, T max, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw OutOfRange(value,min,max,caller,file,line);

        [MethodImpl(NotInline)]
        public static void ThrowBadSize(int expect, int actual, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw new Exception($"The size {actual} is not aligned with {expect}:{FormatCallsite(caller,file,line)}");


        [MethodImpl(NotInline)]
        public static void ThrowIfFalse(bool condition, string msg = null, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            if(!condition)
                throw new Exception($"{msg?? "Invariant Failure"}:{FormatCallsite(caller,file,line)}");
        }
    }
}