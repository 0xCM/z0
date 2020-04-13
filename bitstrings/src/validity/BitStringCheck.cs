//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    using static AppErrorMsg;

    public interface IBitStringEqualityCheck : IEqualCheck<BitString>, INotEqualCheck<BitString>
    {
        void IEqualCheck<BitString>.eq(BitString a, BitString b, string caller, string file, int? line)
        {
            if(!a.Equals(b))
                throw failed(ValidityClaim.Eq, NotEqual(a,b, caller, file, line));
        }

        void INotEqualCheck<BitString>.neq(BitString a, BitString b, string caller, string file, int? line)
        {
            if(a.Equals(b))
                throw failed(ValidityClaim.NEq, Equal(a,b, caller, file, line));
        }
    }

    public interface IBitStringCheck : IBitStringEqualityCheck, ICheckNumeric
    {
        static new IBitStringCheck<BitStringCheck> Checker => BitStringCheck.Checker;
    }

    public interface IBitStringCheck<C> : IBitStringCheck, ICheckNumeric<C>
        where C : IBitStringCheck<C>, new()
    {

    }    

    public readonly struct BitStringCheck : IBitStringCheck<BitStringCheck>
    {
        public static IBitStringCheck<BitStringCheck> Checker => default(BitStringCheck);        
    }
}