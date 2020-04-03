//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using FW = FixedWidth;    
    using NC = NumericClass;

    public enum FixedKind : ushort
    {
        None = 0,
        
        Fixed1 = NC.W1,

        Fixed8 = NC.W8,
        
        Fixed16 = NC.W16,

        Fixed32 = NC.W32,

        Fixed64 = NC.W64,

        Fixed128 = FW.W128,

        Fixed256 = FW.W256,

        Fixed512 = FW.W512,    
    }
}