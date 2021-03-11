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
    using static CheckLengths;
    using static CheckInvariant;
    using static ClaimValidator;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public readonly struct CheckPrimalSeq : ICheckPrimalSeq
    {
        /// <summary>
        /// Returns true if the character spans are equal as strings, false otherwise
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Op]
        public static bool TestEq(ReadOnlySpan<char> a, ReadOnlySpan<char> b)
            => Seq.eq(a, b);

        /// <summary>
        /// Returns true if the character spans are equal as strings, false otherwise
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Op]
        public static bool TestEq(ReadOnlySpan<byte> a, ReadOnlySpan<byte> b)
            => Seq.eq(a,b);

        /// <summary>
        /// Returns true if the character spans are equal as strings, false otherwise
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Op]
        public static bool TestEq(ReadOnlySpan<int> a, ReadOnlySpan<int> b)
            => Seq.eq(a,b);

        /// <summary>
        /// Returns true if the character spans are equal as strings, false otherwise
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline), Op]
        public static bool TestEq(ReadOnlySpan<uint> a, ReadOnlySpan<uint> b)
            => Seq.eq(a,b);

        /// <summary>
        /// Returns true if the character spans are equal as strings, false otherwise
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline), Op]
        public static bool TestEq(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
            => Seq.eq(lhs,rhs);

        /// <summary>
        /// Asserts the equality of two boolean arrays
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="caller">The caller member name</param>
        /// <param name="file">The source file of the calling function</param>
        /// <param name="line">The source file line number where invocation ocurred</param>
        public static void ClaimEq(bool[] lhs, bool[] rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            var count = length(lhs,rhs);
            for(var i = 0; i< count; i++)
                if(lhs[i] != rhs[i])
                    throw exception(ClaimKind.Eq, ItemsNotEqual(i, lhs[i], rhs[i], caller, file, line));
        }

        /// <summary>
        /// Asserts content equality for two character spans
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void ClaimEq(ReadOnlySpan<char> lhs, ReadOnlySpan<char> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => require(TestEq(lhs,rhs), caller, file, line);

        /// <summary>
        /// Asserts content equality for two byte spans
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void ClaimEq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => require(TestEq(lhs, rhs), caller, file, line);

        /// <summary>
        /// Asserts content equality for two byte spans
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void ClaimEq(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => require(TestEq(lhs, rhs), caller, file, line);

        /// <summary>
        /// Asserts content equality for two byte spans
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void ClaimEq(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => require(TestEq(lhs, rhs), caller, file, line);

        /// <summary>
        /// Asserts content equality for two byte spans
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void ClaimEq(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => require(TestEq(lhs, rhs), caller, file, line);
    }
}