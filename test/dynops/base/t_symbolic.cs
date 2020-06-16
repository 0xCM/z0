//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public readonly struct DynamicCase : IDynamicCase, IValidator<DynamicCase,IDynamicCase>
    {        
        public static IDynamicCase Checker => default(DynamicCase);         
    }

    public interface IDynamicCase : ICheckNumeric, ICheckVectors
    {
            
    }
    public abstract class t_dynamic<X> : UnitTest<X, DynamicCase, IDynamicCase>
        where X : t_dynamic<X>, new()
    {
        
    }

}