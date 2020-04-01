//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    using static Seed;

    public interface ICheckPrimal : IValidator
    {
        [MethodImpl(Inline)]   
        bool eq(byte lhs, byte rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Claim.eq(lhs, rhs, caller,file, line);

        [MethodImpl(Inline)]   
        bool eq(sbyte lhs, sbyte rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Claim.eq(lhs, rhs, caller,file, line);

        [MethodImpl(Inline)]   
        bool eq(short lhs, short rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Claim.eq(lhs,rhs, caller,file, line);

        [MethodImpl(Inline)]   
        bool eq(ushort lhs, ushort rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Claim.eq(lhs, rhs, caller,file, line);

        [MethodImpl(Inline)]   
        bool eq(int lhs, int rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Claim.eq(lhs,rhs, caller,file, line);

        [MethodImpl(Inline)]   
        bool eq(int lhs, int rhs, string msg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Claim.eq(lhs, rhs, caller,file, line);

        [MethodImpl(Inline)]   
        bool eq(uint lhs, uint rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Claim.eq(lhs, rhs, caller,file, line);

        [MethodImpl(Inline)]   
        bool eq(long lhs, long rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Claim.eq(lhs, rhs, caller,file, line);

        [MethodImpl(Inline)]   
        bool neq(long lhs, long rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Claim.eq(lhs, rhs, caller,file, line);

        [MethodImpl(Inline)]   
        bool eq(ulong lhs, ulong rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Claim.eq(lhs, rhs, caller,file, line);

        [MethodImpl(Inline)]   
        bool eq(long lhs, ulong rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Claim.eq(lhs, rhs, caller,file, line);

        [MethodImpl(Inline)]   
        bool eq(ulong lhs, long rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Claim.eq(lhs,rhs, caller,file, line);

        [MethodImpl(Inline)]   
        bool eq(char lhs, char rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Claim.eq(lhs, rhs, caller,file, line);

        [MethodImpl(Inline)]   
        bool eq(bool lhs, bool rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Claim.eq(lhs, rhs, caller,file, line);
        
        [MethodImpl(Inline)]   
        bool eq(string lhs, string rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Claim.eq(lhs,rhs, caller,file, line);
    }
}