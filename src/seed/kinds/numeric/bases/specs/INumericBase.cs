//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface INumericBase
    {
        NumericBaseKind Modulus {get;}
    }

    public interface INumericBase<F> : INumericBase
        where F : unmanaged, INumericBase<F>
    {
        
    }
}