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

    public readonly struct CheckVectorBits : ICheckVectorBits, IValidator<CheckVectorBits,ICheckVectorBits>
    {        
        public static ICheckVectorBits Checker => default(CheckVectorBits);         
    }

    public interface ICheckVectorBits : ICheckBitVectors, ICheckBitStrings, ICheckNumeric, ICheckVectors, ICheckBitSpans
    {
            
    }
}