//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

    using static Seed;    

    public interface IOpAddress<W> : ISized<W>
        where W : unmanaged, IDataWidth
    {
    }
    

    public interface IOpAddress<F,W,S> : IOpAddress<W>
        where F : struct, IOpAddress<F,W,S>        
        where W : unmanaged, IDataWidth
        where S : unmanaged
    {
        S Location {get;}            
    }
}