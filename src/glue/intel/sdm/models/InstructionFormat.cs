//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    partial struct IntelSdm
    {
        /// <summary>
        /// Represents an entry in an instruction's binary format table
        /// </summary>
        public struct InstructionFormat
        {
            public Marker Descriptor;

            public string BitFormat;
        }
    }
}