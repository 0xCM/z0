//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    public interface ITypeCodeSource
    {
        PartId Owner {get;}

        ulong[] AssignedCodes {get;}
    }

}