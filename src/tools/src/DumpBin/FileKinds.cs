//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct DumpBin
    {
        public enum FileKinds : uint
        {
            /// <summary>
            /// A dumpbin-generated dissassembly file
            /// </summary>       
            Asm = Flag.Disasm,

            /// <summary>
            /// A dumpbin-generated export file
            /// </summary>       
            Exports = Flag.Exports,

            /// <summary>
            /// A dumpbin-generated raw data file
            /// </summary>       
            Raw = Flag.RawData,

            /// <summary>
            /// A dumpbin-generated address relocation file
            /// </summary>       
            Reloc = Flag.Relocations,

            /// <summary>
            /// A dumpbin-generated pe header file listing
            /// </summary>       
            Headers = Flag.Headers,

            /// <summary>
            /// A dumpbin-generated import libary list
            /// </summary>       
            Imports = Flag.Imports,            
        }

    }    
}