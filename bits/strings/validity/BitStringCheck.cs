//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static AppErrorMsg;
    using static Core;
    
    public interface IBitStringEqualityCheck : IEqualCheck<BitString>, INotEqualCheck<BitString>
    {
        void IEqualCheck<BitString>.eq(BitString a, BitString b)
        {
            if(!a.Equals(b))
                throw failed(ValidityClaim.Eq, NotEqual(a,b));
        }

        void INotEqualCheck<BitString>.neq(BitString a, BitString b)
        {
            if(a.Equals(b))
                throw failed(ValidityClaim.NEq, Equal(a,b));
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
