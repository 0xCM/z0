//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    using static Seed;

    public interface IHexHandler
    {
        void OnHex(HexKind kind);
    }

    public interface IHexHandler<H>
        where H :unmanaged, IHexCode
    {
        void OnHex(H h);
    }

}