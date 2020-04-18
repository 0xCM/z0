//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static AppErrorMsg;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public interface ICheckPrimal : IValidator
    {
        [MethodImpl(Inline)]   
        bool eq(byte lhs, byte rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]   
        bool eq(sbyte lhs, sbyte rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]   
        bool eq(short lhs, short rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]   
        bool eq(ushort lhs, ushort rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]   
        bool eq(int lhs, int rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]   
        bool eq(int lhs, int rhs, string msg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]   
        bool eq(uint lhs, uint rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]   
        bool eq(long lhs, long rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line));
 
        [MethodImpl(Inline)]   
        bool eq(ulong lhs, ulong rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]   
        bool eq(char lhs, char rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]   
        bool eq(bool lhs, bool rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line));
        
        [MethodImpl(Inline)]   
        bool eq(string lhs, string rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => string.Equals(lhs,rhs) ? true : throw failed(ClaimKind.Eq, NotEqual(lhs,rhs, caller, file, line));

        [MethodImpl(Inline)]   
        bool eq(char lhs, char rhs, AppMsg msg)
            => lhs == rhs ? true : throw failed(ClaimKind.Eq, msg);

        [MethodImpl(Inline)]   
        bool eq(bool lhs, bool rhs, AppMsg msg)
            => lhs == rhs ? true : throw failed(ClaimKind.Eq, msg);
        
        [MethodImpl(Inline)]   
        bool eq(string lhs, string rhs, AppMsg msg)
            => lhs == rhs ? true : throw failed(ClaimKind.Eq, msg);

        [MethodImpl(Inline)]   
        bool eq(byte lhs, byte rhs, AppMsg msg)
            => lhs == rhs ? true : throw failed(ClaimKind.Eq, msg);

        [MethodImpl(Inline)]   
        bool eq(sbyte lhs, sbyte rhs, AppMsg msg)
            => lhs == rhs ? true : throw failed(ClaimKind.Eq, msg);

        [MethodImpl(Inline)]   
        bool eq(short lhs, short rhs, AppMsg msg)
            => lhs == rhs ? true : throw failed(ClaimKind.Eq, msg);

        [MethodImpl(Inline)]   
        bool eq(ushort lhs, ushort rhs, AppMsg msg)
            => lhs == rhs ? true : throw failed(ClaimKind.Eq, msg);

        [MethodImpl(Inline)]   
        bool eq(int lhs, int rhs, AppMsg msg)
            => lhs == rhs ? true : throw failed(ClaimKind.Eq, msg);

        [MethodImpl(Inline)]   
        bool eq(uint lhs, uint rhs, AppMsg msg)
            => lhs == rhs ? true : throw failed(ClaimKind.Eq, msg);

        [MethodImpl(Inline)]   
        bool eq(long lhs, long rhs, AppMsg msg)
            => lhs == rhs ? true : throw failed(ClaimKind.Eq, msg);

        [MethodImpl(Inline)]   
        bool eq(ulong lhs, ulong rhs, AppMsg msg)
            => lhs == rhs ? true : throw failed(ClaimKind.Eq, msg);

        [MethodImpl(Inline)]   
        bool neq(char lhs, char rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs != rhs ? true : throw failed(ClaimKind.NEq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]   
        bool neq(string lhs, string rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs != rhs ? true : throw failed(ClaimKind.NEq, Equal(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]   
        bool neq(long lhs, long rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs != rhs ? true : throw failed(ClaimKind.NEq, Equal(lhs, rhs, caller, file, line));
    }
}