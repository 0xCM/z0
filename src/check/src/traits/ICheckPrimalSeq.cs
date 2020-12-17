//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    using api = CheckPrimalSeq;

    public interface ICheckPrimalSeq : ICheckLengths, ICheckInvariant, ICheckPrimal
    {
        bool TestEq(ReadOnlySpan<char> lhs, ReadOnlySpan<char> rhs)
            => api.TestEq(lhs,rhs);

        bool TestEq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
            => api.TestEq(lhs,rhs);

        bool TestEq(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
            => api.TestEq(lhs,rhs);

        bool TestEq(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
            => api.TestEq(lhs,rhs);

        bool TestEq(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
            => api.TestEq(lhs,rhs);

        void ClaimEq(bool[] lhs, bool[] rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.ClaimEq(lhs, rhs, caller, file, line);

        void ClaimEq(ReadOnlySpan<char> lhs, ReadOnlySpan<char> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.ClaimEq(lhs, rhs, caller, file, line);

        void ClaimEq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.ClaimEq(lhs, rhs, caller, file, line);

        void ClaimEq(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.ClaimEq(lhs, rhs, caller, file, line);

        void ClaimEq(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.ClaimEq(lhs, rhs, caller, file, line);

        void ClaimEq(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
             => api.ClaimEq(lhs, rhs, caller, file, line);
   }
}