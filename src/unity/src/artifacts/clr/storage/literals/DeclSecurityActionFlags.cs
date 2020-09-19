//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    partial struct ClrStorage
    {
        [Flags]
        public enum DeclSecurityActionFlags : ushort
        {
            ActionNil = 0x0000,

            Request = 0x0001,

            Demand = 0x0002,

            Assert = 0x0003,

            Deny = 0x0004,

            PermitOnly = 0x0005,

            LinktimeCheck = 0x0006,

            InheritanceCheck = 0x0007,

            RequestMinimum = 0x0008,

            RequestOptional = 0x0009,

            RequestRefuse = 0x000A,

            PrejitGrant = 0x000B,

            PrejitDenied = 0x000C,

            NonCasDemand = 0x000D,

            NonCasLinkDemand = 0x000E,

            NonCasInheritance = 0x000F,

            MaximumValue = 0x000F,

            ActionMask = 0x001F,
        }
    }
}