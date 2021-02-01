//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IAlgebraicFieldOps<T> : ICommutativeRingOps<T>, IDivisionRingOps<T>
        where T : unmanaged
    {

    }
    
    public interface IAlgebraicField<S> : ICommutativeRing<S>, IDivisionRing<S>
            where S : IAlgebraicField<S>, new()
    {

     
    }        
}