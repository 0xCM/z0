//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct DynamicCase : IDynamicCase, IClaimValidator<DynamicCase,IDynamicCase>
    {

    }

    public interface IDynamicCase : ICheckNumeric, ICheckVectors
    {

    }

    public abstract class t_dynamic<X> : UnitTest<X, DynamicCase, IDynamicCase>
        where X : t_dynamic<X>, new()
    {

    }
}