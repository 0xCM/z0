//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    using static Konst;    

    public enum PeHeaderField : uint
    {
        FileName = 0 | (26 << WidthOffset),

        Section = 1 | (10 << WidthOffset),

        Address = 2 | (16 << WidthOffset),

        Size = 3 | (10 << WidthOffset),
        
        EntryPoint = 4 | (16 << WidthOffset),

        CodeBase = 5 | (16 << WidthOffset),

        Gpt = 6 | (16 << WidthOffset),

        GptSize = 7 | (8 << WidthOffset)
    }
    
    public readonly struct PeHeaderRecord
    {
        public readonly FileName FileName;

        public readonly string Section;

        public readonly MemoryAddress Address;

        public readonly ByteSize Size;

        public readonly MemoryAddress EntryPoint;

        public readonly MemoryAddress CodeBase;

        public readonly MemoryAddress GlobalPointerTable;

        public readonly ByteSize GlobalPointerTableSize;

        public PeHeaderRecord(FileName FileName, string Section, MemoryAddress Address, ByteSize Size, MemoryAddress EntryPoint, 
            MemoryAddress CodeBase, MemoryAddress GlobalPointerTable, ByteSize GlobalPointerTableSize)
        {
            this.FileName = FileName;
            this.Section = Section;
            this.Address = Address;
            this.Size = Size;
            this.EntryPoint = EntryPoint;
            this.CodeBase = CodeBase;
            this.GlobalPointerTable = GlobalPointerTable;
            this.GlobalPointerTableSize = GlobalPointerTableSize;
        }
    }
}