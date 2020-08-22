//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    partial class AppErrors
    {
        public static void ThrowOutOfRange<T>(int index, int min, int max, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw IndexOutOfRange(index, min, max, caller, file, line);

        public static void ThrowOutOfRange<T>(T value, T min, T max, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw IndexOutOfRange(value,min,max,caller,file,line);

        public static IndexOutOfRangeException IndexOutOfRange(int index, int min, int max, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new IndexOutOfRangeException(AppErrorMsg.IndexOutOfRange(index, min, max, caller, file, line).ToString());

        public static IndexOutOfRangeException IndexOutOfRange<T>(T value, T min, T max, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new IndexOutOfRangeException($"Value {value} is not between {min} and {max}: line {line}, member {caller} in file {file}");

        public static IndexOutOfRangeException TooManyBytes(int requested, int available, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new IndexOutOfRangeException(AppErrorMsg.TooManyBytes(requested, available, caller, file, line).ToString());

        public static void ThrowTooShort(int dstLen, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw new IndexOutOfRangeException($"The target length {dstLen} is tooShort:{FormatCallsite(caller,file,line)}");
    }
}