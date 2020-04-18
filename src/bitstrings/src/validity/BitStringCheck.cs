//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    using static AppErrorMsg;

    public interface IBitStringEqualityCheck : IValidator
    {
        void eq(BitString a, BitString b, string caller, string file, int? line)
        {
            if(!a.Equals(b))
                throw failed(ClaimKind.Eq, NotEqual(a,b, caller, file, line));
        }

        void neq(BitString a, BitString b, string caller, string file, int? line)
        {
            if(a.Equals(b))
                throw failed(ClaimKind.NEq, Equal(a,b, caller, file, line));
        }
    }

    public interface IBitStringCheck : IBitStringEqualityCheck
    {

    }


}