//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Text;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IDataset
    {


    }
    
    public interface IDataset<F>
        where F : unmanaged, Enum
    {

    }

    public interface TDataset<F>
        where F : unmanaged, Enum
    {

    }    
}