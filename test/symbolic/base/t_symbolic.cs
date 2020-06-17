//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct CheckSymbolic : ICheckSymbolic, IValidator<CheckSymbolic,ICheckSymbolic>
    {        
        public static ICheckSymbolic Checker => default(CheckSymbolic);         
    }

    public interface ICheckSymbolic : ICheckNumeric, ICheckVectors
    {
            
    }
    public abstract class t_symbolic<X> : UnitTest<X, CheckSymbolic, ICheckSymbolic>
        where X : t_symbolic<X>, new()
    {
        
    }

}