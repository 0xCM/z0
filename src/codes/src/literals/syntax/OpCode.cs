//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

    partial class SyntaxAtoms
    {
        /// <summary>    
        /// Defines symbols used to specify opcode syntax
        /// </summary>
        public enum OpCodeAtom : byte
        {
            ib,

            iw,

            id,

            io,

            ﾉr,

            REXᕀW,

            ﾉdigit,

            ᕀrb,

            ᕀrw,

            ᕀrd,

            ᕀro
        }
    }
}