//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using System.Runtime.CompilerServices;

    using static Konst;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public readonly struct Validator
    {
        [MethodImpl(Inline), Op]
        public static int length<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            => lhs.Length == rhs.Length ? lhs.Length : AppErrors.ThrowNotEqualNoCaller(lhs.Length, rhs.Length);

        [MethodImpl(Inline), Op]
        public static int length<T>(T[] lhs, T[] rhs)
            => lhs.Length == rhs.Length ? lhs.Length : AppErrors.ThrowNotEqualNoCaller(lhs.Length, rhs.Length);

        [MethodImpl(Inline), Op]
        public static int length<T>(Span<T> lhs, Span<T> rhs)
            => lhs.Length == rhs.Length ? lhs.Length : AppErrors.ThrowNotEqualNoCaller(lhs.Length, rhs.Length);

        /// <summary>
        /// Creates, but does not throw, a claim exception
        /// </summary>
        /// <param name="claim">The sort of claim that failed</param>
        /// <param name="msg">The failure description</param>
        [MethodImpl(Inline), Op]
        public static ClaimException failed(ClaimKind claim, IAppMsg msg)
            => ClaimException.Define(claim, msg);

        /// <summary>
        /// Creates, but does not throw, a claim exception
        /// </summary>
        /// <param name="claim">The sort of claim that failed</param>
        [MethodImpl(Inline), Op]
        public static ClaimException failed(ClaimKind claim, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => failed(claim, AppMsg.error("failed", caller, file,line));

        /// <summary>
        /// Raises an exception if an invariant does not hold
        /// </summary>
        /// <param name="condition">The invariant state</param>
        /// <param name="claim">The sort of claim that failed</param>
        public static void require(bool condition, ClaimKind claim, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            if(!condition)
                throw failed(claim,caller,file,line);
        }

        /// <summary>
        /// Fails unconditionally with a message
        /// </summary>
        /// <param name="msg">The failure reason</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        [MethodImpl(Inline), Op]
        public static void failmsg(string msg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw failed(ClaimKind.Fail, AppMsg.error(msg, caller, file,line));

        [MethodImpl(Inline), Op]
        public static void fail([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw failed(ClaimKind.Fail, AppMsg.error("failed", caller, file,line));
    }
}