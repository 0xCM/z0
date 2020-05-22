//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    

    public interface IAddress<W> : ISized<W>
        where W : unmanaged, IDataWidth
    {
    }
    

    public interface IAddress<F,W,S> : IAddress<W>
        where F : struct, IAddress<F,W,S>        
        where W : unmanaged, IDataWidth
        where S : unmanaged
    {
        S Location {get;}            
    }

}