//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Pow2x8;

    partial struct FS
    {
        public enum KnownClass : ushort
        {
            Unknown = 0,

            Asm,

            Cil,

            Cs,

            Cpp,
            C,

            Csv,

            Doc,

            Dll,

            Log,

            Json,

            Txt,

            Xml,
        }
    }
}