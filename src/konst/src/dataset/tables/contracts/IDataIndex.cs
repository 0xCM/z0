//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public interface IDataIndex
    {
        CellCount Count {get;}
        
        int Length {get;}
    }
    
    public interface IDataIndex<T> : IDataIndex
    {
        T[] Data {get;}

        Span<T> Edit 
            => Data;

        ReadOnlySpan<T> View  
            => Data;

        CellCount IDataIndex.Count
            => Data.Length;

        int IDataIndex.Length 
            => Data.Length;
    }
}