//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct DumpBin
    {
        public enum ExtMap : ulong
        {
            /// <summary>
            /// A dumpbin-generated dissassembly file
            /// </summary>       
            Asm = Flag.Disasm,

            /// <summary>
            /// A dumpbin-generated raw data file
            /// </summary>       
            Raw = Flag.RawData,

            /// <summary>
            /// A dumpbin-generated address relocation file
            /// </summary>       
            Reloc = Flag.Relocations,
        }
    }    
}