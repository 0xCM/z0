//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Data;

    using static Konst;    
    
    public struct PeHeaderRecord : ITable<PeHeaderField,PeHeaderRecord>
    {
        public FileName FileName;

        public string Section;

        public MemoryAddress Address;

        public ByteSize Size;

        public MemoryAddress EntryPoint;

        public MemoryAddress CodeBase;

        public MemoryAddress GlobalPointerTable;

        public ByteSize GlobalPointerTableSize;

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