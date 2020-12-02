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

    using api = CheckPrimal;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public interface TCheckPrimal : TValidator
    {
        bool eq(bit lhs, bit rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.eq(lhs, rhs, caller, file, line);

        bool eq(char lhs, char rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.eq(lhs, rhs, caller, file, line);

        bool eq(string lhs, string rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.eq(lhs, rhs, caller, file, line);

        bool eq(byte lhs, byte rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.eq(lhs, rhs, caller, file, line);

        bool eq(sbyte lhs, sbyte rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.eq(lhs, rhs, caller, file, line);

        bool eq(short lhs, short rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.eq(lhs, rhs, caller, file, line);

        bool eq(ushort lhs, ushort rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.eq(lhs, rhs, caller, file, line);

        bool eq(int lhs, int rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.eq(lhs, rhs, caller, file, line);

        bool eq(uint lhs, uint rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.eq(lhs, rhs, caller, file, line);

        bool eq(long lhs, long rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.eq(lhs, rhs, caller, file, line);

        bool eq(ulong lhs, ulong rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.eq(lhs, rhs, caller, file, line);

        bool eq(bool lhs, bool rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => api.eq(lhs, rhs, caller, file, line);

        bool eq(uint lhs, uint rhs, AppMsg msg)
            => lhs == rhs ? true : throw Failed(ClaimKind.Eq, msg);

        bool neq(char lhs, char rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs != rhs ? true : throw Failed(ClaimKind.NEq, NotEqual(lhs, rhs, caller, file, line));

        bool neq(string lhs, string rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs != rhs ? true : throw Failed(ClaimKind.NEq, Equal(lhs, rhs, caller, file, line));

        bool neq(long lhs, long rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs != rhs ? true : throw Failed(ClaimKind.NEq, Equal(lhs, rhs, caller, file, line));

        bool eq(int? lhs, int? rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw Failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        bool eq(int? lhs, int? rhs, string msg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw Failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line));
    }
}