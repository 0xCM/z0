//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AppErrorMsg;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;
    using api = ClaimValidator;

    [ApiHost]
    public readonly struct CheckPrimal
    {
        [MethodImpl(Inline), Op]
        public static bool require(bool src, string msg = null, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => !src ? @throw<bool>(ClaimException.define(ClaimKind.Invariant,NotTrue(msg, caller, file,line).Format())) : true;

        [MethodImpl(Inline), Op]
        public static bool eq(char lhs, char rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : @throw<bool>(Failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line)));

        [MethodImpl(Inline), Op]
        public static bool eq(string lhs, string rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => string.Equals(lhs,rhs) ? true : @throw<bool>(Failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line)));

        [MethodImpl(Inline), Op]
        public static bool eq(byte lhs, byte rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : @throw<bool>(Failed(ClaimKind.Eq, NotEqual(lhs,rhs, caller, file, line)));

        [MethodImpl(Inline), Op]
        public static bool eq(sbyte lhs, sbyte rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : @throw<bool>(Failed(ClaimKind.Eq, NotEqual(lhs,rhs, caller, file, line)));

        [MethodImpl(Inline), Op]
        public static bool eq(short lhs, short rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : @throw<bool>(Failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line)));

        [MethodImpl(Inline), Op]
        public static bool eq(ushort lhs, ushort rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : @throw<bool>(Failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line)));

        [MethodImpl(Inline), Op]
        public static bool eq(int lhs, int rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : @throw<bool>(Failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line)));

        [MethodImpl(Inline), Op]
        public static bool eq(uint lhs, uint rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : @throw<bool>(Failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line)));

        [MethodImpl(Inline), Op]
        public static bool eq(long lhs, long rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : @throw<bool>(Failed(ClaimKind.Eq, NotEqual(lhs,rhs, caller, file, line)));

        [MethodImpl(Inline), Op]
        public static bool eq(ulong lhs, ulong rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : @throw<bool>(Failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line)));

        [MethodImpl(Inline), Op]
        public static bool eq(bool lhs, bool rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : @throw<bool>(Failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line)));

        [MethodImpl(Inline), Op]
        public static bool eq(bit lhs, bit rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : @throw<bit>(Failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line)));

        [MethodImpl(Inline), Op]
        public static bool neq(char lhs, char rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs != rhs ? true : @throw<bool>(Failed(ClaimKind.NEq, NotEqual(lhs, rhs, caller, file, line)));

        [MethodImpl(Inline), Op]
        public static bool neq(string lhs, string rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs != rhs ? true : @throw<bool>(Failed(ClaimKind.NEq, Equal(lhs, rhs, caller, file, line)));

        [MethodImpl(Inline), Op]
        public static bool neq(long lhs, long rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs != rhs ? true : @throw<bool>(Failed(ClaimKind.NEq, Equal(lhs, rhs, caller, file, line)));

        [MethodImpl(Inline), Op]
        public static bool eq(int? lhs, int? rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : @throw<bool>(Failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line)));
        public static unsafe void notnull(void* p, string msg = null, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => (p != null).OnNone(() => throw new ArgumentNullException(AppMsg.called($"Pointer was null", LogLevel.Error, caller,file,line).ToString()));

        [MethodImpl(Inline), Op]
        static ClaimException Failed(ClaimKind claim, IAppMsg msg)
            => api.exception(claim, msg);
    }
}