//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    public readonly struct PeImageHeader
    {        
        public readonly IMAGE_FILE_MACHINE Machine;

        public readonly ushort NumberOfSections;

        public readonly uint TimeDateStamp;
        
        public readonly uint PointerToSymbolTable;
        
        public readonly uint NumberOfSymbols;
        
        public readonly ushort SizeOfOptionalHeader;
        
        public readonly IMAGE_FILE Characteristics;        

        public PeImageHeader(IMAGE_FILE_HEADER src)
        {
            Machine = src.Machine;
            NumberOfSections = src.NumberOfSections;
            TimeDateStamp = src.TimeDateStamp;
            NumberOfSymbols = src.NumberOfSymbols;
            PointerToSymbolTable = src.PointerToSymbolTable;
            SizeOfOptionalHeader = src.SizeOfOptionalHeader;
            Characteristics = (IMAGE_FILE)src.Characteristics;
        }
    }
}