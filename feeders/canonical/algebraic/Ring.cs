//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes a (unital) ring
    /// </summary>
    public interface IRingOps<T> : IGroupAOps<T>, IMonoidMOps<T>, IDistributiveOps<T> 
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a commutative, unital ring
    /// </summary>
    public interface ICommutativeRingOps<T> : IRingOps<T>
        where T : unmanaged
    {
        
    }

    public interface IDivisionRingOps<T> : IRingOps<T>, IDivisiveOps<T>, IReciprocativeOps<T>
        where T : unmanaged
    {


    }

    public interface IRing<S> : IGroupA<S>, IMonoidM<S>, IDistributive<S>
        where S : IRing<S>, new()
    {

    }
    
    public interface IRing<S,T> : IRing<S>, IGroupA<S,T>, IMonoidM<S,T>, IDistributive<S,T>
        where S : IRing<S,T>, new()
    {
        
    }

    public interface ICommutativeRing<S> : IRing<S>
        where S : ICommutativeRing<S>, new()
    {

    }


    public interface IDivisionRing<S> : IRing<S>, IDivisive<S>, IReciprocative<S>
        where S : IDivisionRing<S>, new()
    {

    }
}