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

    public interface ITableSelectors<D,S>
        where D : unmanaged, Enum        
        where S : unmanaged
    {
        S MinId {get;}

        S MaxId {get;}

        S[] Index {get;}
        
        ClosedInterval<ulong> Positions {get;}

        ClosedInterval<ulong> Indices {get;}        
        
        ulong Offset {get;}        
        
        ref TableSelector<D,S> this[D id] {get;}

        ref TableSelector<D,S> this[S index] {get;}

        ref TableSelector<D,S> this[ulong index] {get;}                
    }

    public interface ITableSelectors<H,D,S> : ITableSelectors<D,S>
        where D : unmanaged, Enum        
        where S : unmanaged
        where H : struct, ITableSelectors<H,D,S>
    {

    }
}