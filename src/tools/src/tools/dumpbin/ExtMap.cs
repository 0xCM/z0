//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    partial struct DumpBin
    {
        public enum ExtMap : ulong
        {
            /// <summary>
            /// A dumpbin-generated disassembly file
            /// </summary>       
            Asm = DumpBinFlag.Disasm,

            /// <summary>
            /// A dumpbin-generated raw data file
            /// </summary>       
            Raw = DumpBinFlag.RawData,

            /// <summary>
            /// A dumpbin-generated address relocation file
            /// </summary>       
            Relocation = DumpBinFlag.Relocations,
        }
    }    
}