//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    public abstract class t_bitcore<X> : UnitTest<X>
        where X : t_bitcore<X>, new()
    {
        protected override int RepCount => Pow2.T04;

        protected override int CycleCount => Pow2.T03;       

        protected new IBitSuiteMix Claim => IBitSuiteMix.Checker;        
    }

    public readonly struct BitSuiteCheck : IBitSuiteMix
    {        
    
    }

    public interface IBitSuiteMix : IBitVectorCheck, IBitStringCheck, ICheckNumeric
    {
        static new IBitSuiteMix Checker => default(BitSuiteCheck);         
    }
}