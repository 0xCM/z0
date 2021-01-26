//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static AppErrorMsg;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public readonly struct CheckBitStrings : ICheckBitStrings
    {
        public static ICheckBitStrings Checker => default(CheckBitStrings);
    }

    public interface ICheckBitStrings : IClaimValidator
    {
        void eq(BitString a, BitString b, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            if(!a.Equals(b))
                throw Failed(ClaimKind.Eq, NotEqual(a,b, caller, file, line));
        }

        void neq(BitString a, BitString b, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        {
            if(a.Equals(b))
                throw Failed(ClaimKind.NEq, Equal(a,b, caller, file, line));
        }
    }
}