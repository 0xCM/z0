//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;
    using static AppErrorMsg;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;
    using api = Validator;

    [ApiHost]
    public readonly struct CheckPrimal
    {
        /// <summary>
        /// Asserts the operand is true
        /// </summary>
        /// <param name="src">The value claimed to be false</param>
        /// <param name="msg">An optional message describint the assertion</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        [MethodImpl(Inline), Op]
        public static bool require(bool src, string msg = null, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => !src ? @throw<bool>(ClaimException.Define(NotTrue(msg, caller, file,line))) : true;

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

        /// <summary>
        /// Asserts the pointer is not null
        /// </summary>
        /// <param name="p">The pointer to check</param>
        /// <param name="msg">An optional message describint the assertion</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static unsafe void notnull(void* p, string msg = null, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => (p != null).OnNone(() => throw new ArgumentNullException(AppMsg.called($"Pointer was null", LogLevel.Error, caller,file,line).ToString()));

        /// <summary>
        /// Creates, but does not throw, a claim exception
        /// </summary>
        /// <param name="claim">The sort of claim that failed</param>
        /// <param name="msg">The failure description</param>
        [MethodImpl(Inline), Op]
        static ClaimException Failed(ClaimKind claim, IAppMsg msg)
            => api.exception(claim, msg);
    }
}