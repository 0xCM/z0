//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    /// <summary>
    /// Defines the available cpu operating modes
    /// </summary>
    /// <remarks>
    /// See Amd.Vol(3).Table(1.2)
    /// </remarks>
    [Flags]
    public enum OperatingMode : byte
    {
        None = 0,

        Mode16 = 1,

        Mode32 = 2,

        Mode64 = 4,

        Protected = 8,

        Virtual8086 = 16,

        Compatibilty = 64,

        Real = 32,

        Legacy = Protected | Virtual8086 | Real,

        Long = Mode64 | Compatibilty,

        Non64 = (unchecked((byte)~Mode64))
    }
}