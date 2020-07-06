//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IDataFields<F>
        where F : unmanaged,Enum
    {
        F[] Literals {get;}

        string[] Labels {get;}

        short Width(F f);

        short Index(F f);        
    }
}