//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
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
        [Op]
        public static bool yea(bool src, string msg = null, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => !src ? @throw<bool>(ClaimException.Define(NotTrue(msg, caller, file,line))) : true;

        [Op]
        public static bool eq(char lhs, char rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : @throw<bool>(Failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line)));

        [Op]
        public static bool eq(string lhs, string rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => string.Equals(lhs,rhs) ? true : @throw<bool>(Failed(ClaimKind.Eq, NotEqual(lhs,rhs, caller, file, line)));

        [Op]
        public static bool eq(byte lhs, byte rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : @throw<bool>(Failed(ClaimKind.Eq, NotEqual(lhs,rhs, caller, file, line)));

        [Op]
        public static bool eq(sbyte lhs, sbyte rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : @throw<bool>(Failed(ClaimKind.Eq, NotEqual(lhs,rhs, caller, file, line)));

        [Op]
        public static bool eq(short lhs, short rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : @throw<bool>(Failed(ClaimKind.Eq, NotEqual(lhs,rhs, caller, file, line)));

        [Op]
        public static bool eq(ushort lhs, ushort rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : @throw<bool>(Failed(ClaimKind.Eq, NotEqual(lhs,rhs, caller, file, line)));

        [Op]
        public static bool eq(int lhs, int rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : @throw<bool>(Failed(ClaimKind.Eq, NotEqual(lhs,rhs, caller, file, line)));

        [Op]
        public static bool eq(int lhs, int rhs, string msg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : @throw<bool>(Failed(ClaimKind.Eq, NotEqual(lhs,rhs, caller, file, line)));

        [Op]
        public static bool eq(uint lhs, uint rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : @throw<bool>(Failed(ClaimKind.Eq, NotEqual(lhs,rhs, caller, file, line)));

        [Op]
        public static bool eq(long lhs, long rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : @throw<bool>(Failed(ClaimKind.Eq, NotEqual(lhs,rhs, caller, file, line)));

        [Op]
        public static bool eq(ulong lhs, ulong rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : @throw<bool>(Failed(ClaimKind.Eq, NotEqual(lhs,rhs, caller, file, line)));

        [Op]
        public static bool eq(bool lhs, bool rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : @throw<bool>(Failed(ClaimKind.Eq, NotEqual(lhs,rhs, caller, file, line)));

        [Op]
        public static bool eq(uint lhs, uint rhs, AppMsg msg)
            => lhs == rhs ? true : throw Failed(ClaimKind.Eq, msg);

        [Op]
        public static bool eq(long lhs, long rhs, AppMsg msg)
            => lhs == rhs ? true : throw Failed(ClaimKind.Eq, msg);

        [Op]
        public static bool eq(ulong lhs, ulong rhs, AppMsg msg)
            => lhs == rhs ? true : throw Failed(ClaimKind.Eq, msg);

        [Op]
        bool neq(char lhs, char rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs != rhs ? true : throw Failed(ClaimKind.NEq, NotEqual(lhs, rhs, caller, file, line));

        [Op]
        bool neq(string lhs, string rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs != rhs ? true : throw Failed(ClaimKind.NEq, Equal(lhs, rhs, caller, file, line));

        [Op]
        bool neq(long lhs, long rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs != rhs ? true : throw Failed(ClaimKind.NEq, Equal(lhs, rhs, caller, file, line));

        [Op]
        public static bool eq(int? lhs, int? rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw Failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        [Op]
        public static bool eq(int? lhs, int? rhs, string msg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw Failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line));

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