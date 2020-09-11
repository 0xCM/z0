//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct CheckSymbolic : TCheckSymbolic, TValidator<CheckSymbolic,TCheckSymbolic>
    {
        public static TCheckSymbolic Checker => default(CheckSymbolic);
    }

    public interface TCheckSymbolic : TCheckNumeric, ICheckVectors
    {

    }
    public abstract class t_symbolic<X> : UnitTest<X, CheckSymbolic, TCheckSymbolic>
        where X : t_symbolic<X>, new()
    {

    }

}