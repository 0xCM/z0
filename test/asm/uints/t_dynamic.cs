//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct DynamicCase : IDynamicCase, TValidator<DynamicCase,IDynamicCase>
    {
        public static IDynamicCase Checker => default(DynamicCase);
    }

    public interface IDynamicCase : TCheckNumeric, ICheckVectors
    {

    }
    public abstract class t_dynamic<X> : UnitTest<X, DynamicCase, IDynamicCase>
        where X : t_dynamic<X>, new()
    {

    }
}