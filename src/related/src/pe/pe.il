.class public sequential ansi sealed beforefieldinit Z0.PeRecords
       extends [System.Runtime]System.ValueType
{
  .pack 0
  .size 1
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
  .custom instance void [z0.root]Z0.RecordSetAttribute::.ctor() = ( 01 00 00 00 )
  .class sequential ansi sealed nested public beforefieldinit BaseRelocationRow
         extends [System.Runtime]System.ValueType
         implements class [z0.part]Z0.IRecord`1<valuetype Z0.PeRecords/BaseRelocationRow>,
                    [z0.part]Z0.IRecord
  {
    .custom instance void [z0.root]Z0.RecordAttribute::.ctor(string,
                                                             uint8) = ( 01 00 00 00 00 00 )
    .field public valuetype [z0.part]Z0.Address32 VirtualAddress
    .field public uint32 SizeOfBlock
  } // end of class BaseRelocationRow

  .class sequential ansi sealed nested public beforefieldinit CoffHeaderRow
         extends [System.Runtime]System.ValueType
         implements class [z0.part]Z0.IRecord`1<valuetype Z0.PeRecords/CoffHeaderRow>,
                    [z0.part]Z0.IRecord
  {
    .custom instance void [z0.root]Z0.RecordAttribute::.ctor(string,
                                                             uint8) = ( 01 00 0E 70 65 2E 63 6F 66 66 2D 68 65 61 64 65   // ...pe.coff-heade
                                                                        72 00 00 00 )                                     // r...
    .field public static literal string TableId = "pe.coff-header"
    .field public valuetype [System.Reflection.Metadata]System.Reflection.PortableExecutable.Machine Machine
    .field public uint16 NumberOfSections
    .field public uint32 TimeDateStamp
    .field public valuetype [z0.part]Z0.Address32 PointerToSymbolTable
    .field public uint32 NumberOfSymbols
    .field public uint16 SizeOfOptionalHeader
    .field public valuetype [System.Reflection.Metadata]System.Reflection.PortableExecutable.Characteristics Characteristics
  } // end of class CoffHeaderRow

  .class sequential ansi sealed nested public beforefieldinit CorHeaderRow
         extends [System.Runtime]System.ValueType
         implements class [z0.part]Z0.IRecord`1<valuetype Z0.PeRecords/CorHeaderRow>,
                    [z0.part]Z0.IRecord
  {
    .custom instance void [z0.root]Z0.RecordAttribute::.ctor(string,
                                                             uint8) = ( 01 00 0C 70 65 2D 63 6F 72 68 65 61 64 65 72 00   // ...pe-corheader.
                                                                        00 00 )
    .field public static literal string TableId = "pe-corheader"
    .field public uint16 MajorRuntimeVersion
    .field public uint16 MinorRuntimeVersion
    .field public valuetype Z0.PeRecords/DirectoryEntryRow MetadataDirectory
    .field public valuetype [System.Reflection.Metadata]System.Reflection.PortableExecutable.CorFlags Flags
    .field public int32 EntryPointTokenOrRelativeVirtualAddress
    .field public valuetype Z0.PeRecords/DirectoryEntryRow ResourcesDirectory
    .field public valuetype Z0.PeRecords/DirectoryEntryRow StrongNameSignatureDirectory
    .field public valuetype Z0.PeRecords/DirectoryEntryRow CodeManagerTableDirectory
    .field public valuetype Z0.PeRecords/DirectoryEntryRow VtableFixupsDirectory
    .field public valuetype Z0.PeRecords/DirectoryEntryRow ExportAddressTableJumpsDirectory
    .field public valuetype Z0.PeRecords/DirectoryEntryRow ManagedNativeHeaderDirectory
  } // end of class CorHeaderRow

  .class sequential ansi sealed nested public beforefieldinit DirectoryEntryRow
         extends [System.Runtime]System.ValueType
         implements class [z0.part]Z0.IRecord`1<valuetype Z0.PeRecords/DirectoryEntryRow>,
                    [z0.part]Z0.IRecord
  {
    .custom instance void [z0.root]Z0.RecordAttribute::.ctor(string,
                                                             uint8) = ( 01 00 12 70 65 2E 64 69 72 65 63 74 6F 72 79 2D   // ...pe.directory-
                                                                        65 6E 74 72 79 00 00 00 )                         // entry...
    .field public static literal string TableId = "pe.directory-entry"
    .field public valuetype [z0.part]Z0.Address32 Rva
    .field public uint32 Size
  } // end of class DirectoryEntryRow

  .class sequential ansi sealed nested public beforefieldinit FieldOffset
         extends [System.Runtime]System.ValueType
         implements class [z0.part]Z0.IRecord`1<valuetype Z0.PeRecords/FieldOffset>,
                    [z0.part]Z0.IRecord
  {
    .custom instance void [z0.root]Z0.RecordAttribute::.ctor(string,
                                                             uint8) = ( 01 00 0D 69 6D 61 67 65 2E 6F 66 66 73 65 74 73   // ...image.offsets
                                                                        00 00 00 )
    .field public static literal string TableId = "image.offsets"
    .field public string Name
    .field public uint64 Value
  } // end of class FieldOffset

  .class auto ansi sealed nested public ImageSectionKind
         extends [System.Runtime]System.Enum
  {
    .custom instance void [z0.root]Z0.DocAttribute::.ctor(string) = ( 01 00 44 68 74 74 70 3A 2F 2F 77 77 77 2E 68 65   // ..Dhttp://www.he
                                                                      78 61 63 6F 72 6E 2E 63 6F 6D 2F 62 6C 6F 67 2F   // xacorn.com/blog/
                                                                      32 30 31 36 2F 31 32 2F 31 35 2F 70 65 2D 73 65   // 2016/12/15/pe-se
                                                                      63 74 69 6F 6E 2D 6E 61 6D 65 73 2D 72 65 2D 76   // ction-names-re-v
                                                                      69 73 69 74 65 64 2F 00 00 )                      // isited/..
    .field public specialname rtspecialname uint8 value__
    .field public static literal valuetype Z0.PeRecords/ImageSectionKind Unknown = uint8(0x00)
    .field public static literal valuetype Z0.PeRecords/ImageSectionKind Data = uint8(0x01)
    .custom instance void [z0.root]Z0.SymbolAttribute::.ctor(string) = ( 01 00 05 2E 64 61 74 61 00 00 )                   // ....data..
    .field public static literal valuetype Z0.PeRecords/ImageSectionKind ResourceSection = uint8(0x02)
    .custom instance void [z0.root]Z0.SymbolAttribute::.ctor(string) = ( 01 00 05 2E 72 73 72 63 00 00 )                   // ....rsrc..
    .field public static literal valuetype Z0.PeRecords/ImageSectionKind Text = uint8(0x03)
    .custom instance void [z0.root]Z0.SymbolAttribute::.ctor(string) = ( 01 00 05 2E 74 65 78 74 00 00 )                   // ....text..
    .field public static literal valuetype Z0.PeRecords/ImageSectionKind RelocationTable = uint8(0x04)
    .custom instance void [z0.root]Z0.SymbolAttribute::.ctor(string) = ( 01 00 06 2E 72 65 6C 6F 63 00 00 )                // ....reloc..
    .field public static literal valuetype Z0.PeRecords/ImageSectionKind Debug = uint8(0x05)
    .custom instance void [z0.root]Z0.SymbolAttribute::.ctor(string) = ( 01 00 06 2E 64 65 62 75 67 00 00 )                // ....debug..
    .field public static literal valuetype Z0.PeRecords/ImageSectionKind ThreadLocalStorage = uint8(0x06)
    .custom instance void [z0.root]Z0.SymbolAttribute::.ctor(string) = ( 01 00 04 2E 74 6C 73 00 00 )                      // ....tls..
    .field public static literal valuetype Z0.PeRecords/ImageSectionKind Directive = uint8(0x07)
    .custom instance void [z0.root]Z0.SymbolAttribute::.ctor(string) = ( 01 00 08 2E 64 72 65 63 74 76 65 00 00 )          // ....drectve..
    .field public static literal valuetype Z0.PeRecords/ImageSectionKind ExportData = uint8(0x08)
    .custom instance void [z0.root]Z0.SymbolAttribute::.ctor(string) = ( 01 00 06 2E 65 64 61 74 61 00 00 )                // ....edata..
    .field public static literal valuetype Z0.PeRecords/ImageSectionKind InitializedData = uint8(0x09)
    .custom instance void [z0.root]Z0.SymbolAttribute::.ctor(string) = ( 01 00 06 2E 69 64 61 74 61 00 00 )                // ....idata..
    .field public static literal valuetype Z0.PeRecords/ImageSectionKind ReadOnlyData = uint8(0x0A)
    .custom instance void [z0.root]Z0.SymbolAttribute::.ctor(string) = ( 01 00 06 2E 72 64 61 74 61 00 00 )                // ....rdata..
    .field public static literal valuetype Z0.PeRecords/ImageSectionKind ExceptionData = uint8(0x0B)
    .custom instance void [z0.root]Z0.SymbolAttribute::.ctor(string) = ( 01 00 06 2E 70 64 61 74 61 00 00 )                // ....pdata..
    .field public static literal valuetype Z0.PeRecords/ImageSectionKind ClrMetadata = uint8(0x0C)
    .custom instance void [z0.root]Z0.SymbolAttribute::.ctor(string) = ( 01 00 08 2E 63 6F 72 6D 65 74 61 00 00 )          // ....cormeta..
  } // end of class ImageSectionKind

  .class sequential ansi sealed nested public beforefieldinit ResDataEntry
         extends [System.Runtime]System.ValueType
         implements class [z0.part]Z0.IRecord`1<valuetype Z0.PeRecords/ResDataEntry>,
                    [z0.part]Z0.IRecord
  {
    .custom instance void [z0.root]Z0.RecordAttribute::.ctor(string,
                                                             uint8) = ( 01 00 11 70 65 2E 72 65 73 2D 64 61 74 61 2D 65   // ...pe.res-data-e
                                                                        6E 74 72 79 00 00 00 )                            // ntry...
    .field public static literal string TableId = "pe.res-data-entry"
    .field public valuetype [z0.part]Z0.Address32 RvaToData
    .field public uint32 Size
    .field public uint32 CodePage
    .field public uint32 Reserved
  } // end of class ResDataEntry

  .class sequential ansi sealed nested public beforefieldinit ResourceDirectory
         extends [System.Runtime]System.ValueType
         implements class [z0.part]Z0.IRecord`1<valuetype Z0.PeRecords/ResourceDirectory>,
                    [z0.part]Z0.IRecord
  {
    .custom instance void [z0.root]Z0.RecordAttribute::.ctor(string,
                                                             uint8) = ( 01 00 0C 69 6D 61 67 65 2E 72 65 73 64 69 72 00   // ...image.resdir.
                                                                        00 00 )
    .field public static literal string TableId = "image.resdir"
    .field public uint32 Characteristics
    .field public uint32 Timestamp
    .field public uint16 MajorVersion
    .field public uint16 MinorVersion
    .field public uint16 NumberOfNamedEntries
    .field public uint16 NumberOfIdEntries
  } // end of class ResourceDirectory

  .class sequential ansi sealed nested public beforefieldinit ResourceDirectoryEntry
         extends [System.Runtime]System.ValueType
  {
    .custom instance void [z0.root]Z0.RecordAttribute::.ctor(string,
                                                             uint8) = ( 01 00 12 69 6D 61 67 65 2E 72 65 73 64 69 72 2E   // ...image.resdir.
                                                                        65 6E 74 72 79 00 00 00 )                         // entry...
    .field public static literal string TableId = "image.resdir.entry"
    .field public uint32 NameOffset
    .field public uint32 Id
    .field public uint32 DataEntryOffset
    .field public uint32 SubdirectoryOffset
  } // end of class ResourceDirectoryEntry

  .class sequential ansi sealed nested public beforefieldinit SectionHeaderInfo
         extends [System.Runtime]System.ValueType
         implements class [z0.part]Z0.IRecord`1<valuetype Z0.PeRecords/SectionHeaderInfo>,
                    [z0.part]Z0.IRecord
  {
    .custom instance void [z0.root]Z0.RecordAttribute::.ctor(string,
                                                             uint8) = ( 01 00 0D 69 6D 61 67 65 2E 68 65 61 64 65 72 73   // ...image.headers
                                                                        00 00 00 )
    .field public static literal string TableId = "image.headers"
    .field public valuetype [z0.part]Z0.FS/FileName File
    .field public string SectionName
    .field public valuetype [z0.part]Z0.Address32 CodeBase
    .field public valuetype [z0.part]Z0.Address32 GptRva
    .field public valuetype [z0.part]Z0.ByteSize GptSize
    .field public valuetype [System.Reflection.Metadata]System.Reflection.PortableExecutable.SectionCharacteristics SectionAspects
    .field public valuetype [z0.part]Z0.Address32 RawDataAddress
    .field public valuetype [z0.part]Z0.ByteSize RawDataSize
    .field public valuetype [z0.part]Z0.Address32 EntryPoint
  } // end of class SectionHeaderInfo

  .method public hidebysig static valuetype Z0.PeRecords/DirectoryEntryRow
          directory(valuetype [z0.part]Z0.Address32 rva,
                    uint32 size) cil managed aggressiveinlining
  // SIG: 00 02 11 82 8C 11 5D 09
  {
    .custom instance void [z0.root]OpAttribute::.ctor() = ( 01 00 00 00 )
    // Method begins at RVA 0x21a8
    // Code size       26 (0x1a)
    .maxstack  2
    .locals init ([0] valuetype Z0.PeRecords/DirectoryEntryRow dst)
    .line 19,19 : 13,47 'c:\\dev\\z0\\src\\related\\src\\PeRecords.cs'
    IL_0000:  /* 12   | 00               */ ldloca.s   dst
    IL_0002:  /* FE15 | (02)0000A3       */ initobj    Z0.PeRecords/DirectoryEntryRow
    .line 20,20 : 13,27 ''
    IL_0008:  /* 12   | 00               */ ldloca.s   dst
    IL_000a:  /* 02   |                  */ ldarg.0
    IL_000b:  /* 7D   | (04)0003B8       */ stfld      valuetype [z0.part]Z0.Address32 Z0.PeRecords/DirectoryEntryRow::Rva
    .line 21,21 : 13,29 ''
    IL_0010:  /* 12   | 00               */ ldloca.s   dst
    IL_0012:  /* 03   |                  */ ldarg.1
    IL_0013:  /* 7D   | (04)0003B9       */ stfld      uint32 Z0.PeRecords/DirectoryEntryRow::Size
    .line 22,22 : 13,24 ''
    IL_0018:  /* 06   |                  */ ldloc.0
    IL_0019:  /* 2A   |                  */ ret
  } // end of method PeRecords::directory

} // end of class Z0.PeRecords
