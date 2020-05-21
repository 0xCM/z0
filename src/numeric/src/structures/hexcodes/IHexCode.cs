//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IHexCode
    {
        HexKind Kind {get;}        

        Type Reified {get;}
    }

    public interface IHexCode<H> : IHexCode
        where H : unmanaged, IHexCode<H>
    {
        Type IHexCode.Reified 
        {
            [MethodImpl(Inline)]
            get => typeof(H);   
        }
    }
}