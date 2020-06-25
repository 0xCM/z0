//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    public interface IHexSavedBroker : IEventBroker
    {
        HexCodeSaved HexSaved => HexCodeSaved.Empty;        
    }

}