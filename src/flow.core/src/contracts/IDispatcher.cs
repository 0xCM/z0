//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public interface IDispatcher<F,T,D,S,Y> : IWfActor
        where F : unmanaged, Enum
        where T : struct, ITable<F,T,D>
        where D : unmanaged, Enum        
        where S : unmanaged
    {                
        void Process(T[] src, Y[] dst);        
    }
}