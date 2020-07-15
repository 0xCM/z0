//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    /// <summary>
    /// A byte, just one
    /// </summary>
    public interface IByte : IHashed
    {
        byte Value {get;}

        uint IHashed.Hash 
            => Value;
    }

    public interface IByte<F> : IByte, IHashed<F>
        where F : unmanaged, IByte<F>
    {

    }
}