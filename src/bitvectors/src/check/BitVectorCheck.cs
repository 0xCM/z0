//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Seed;

    public interface IBitVectorCheck : IBitVectorEqualityCheck, ICheckNumeric
    {
        static new IBitVectorCheck Checker => default(BitVectorCheck);
    }
    
    public readonly struct BitVectorCheck : IBitVectorCheck
    {

    }
}