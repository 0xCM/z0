//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dac
{
    using System;

    public enum DeclarativeSecurityAction : short
    {
        None = (short)0,
     
        Demand = (short)2,
     
        Assert = (short)3,
     
        Deny = (short)4,
     
        PermitOnly = (short)5,
     
        LinkDemand = (short)6,
     
        InheritanceDemand = (short)7,
     
        RequestMinimum = (short)8,
     
        RequestOptional = (short)9,
     
        RequestRefuse = (short)10,
    }
}