//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Security;

    public interface ITableRow : ITextual
    {
        string ITextual.Format()
            => "Unformatted";

        BinaryCode[] Cells {get;}            
    }

    public interface ITableRow<F> : ITableRow
        where F : unmanaged, Enum
    {

    }

    public interface ITableRow<F,T> : ITableRow<F>
        where F : unmanaged, Enum
        where T : struct, ITable<F,T>
    {
        T Data {get;}
    }    
}