//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using Windows.Image;

    using static Root;
    using static core;

    public abstract class CoffSection<T>
        where T : CoffSection<T>
    {
        protected StringAddress NameAddress {get;}

        protected MemoryAddress BaseAddress {get;}

        public uint Size {get;}

        protected CoffSection(StringAddress name, MemoryAddress @base, uint size)
        {
            NameAddress = name;
            BaseAddress = @base;
            Size = size;
        }

        public string Name
        {
            [MethodImpl(Inline)]
            get => NameAddress.Format();
        }
    }

    public class CoffSections
    {
        public sealed class Bss : CoffSection<Bss>
        {
            internal Bss(MemoryAddress @base, uint size)
                : base(".bss", @base, size)
            {

            }
        }

        public sealed class Text : CoffSection<Text>
        {
            internal Text(MemoryAddress @base, uint size)
                : base(".text", @base, size)
            {

            }
        }

        public sealed class RData : CoffSection<RData>
        {
            internal RData(MemoryAddress @base, uint size)
                : base(".rdata", @base, size)
            {

            }
        }
    }

    public partial class CoffObject : IDisposable
    {
        readonly NativeBuffer Data;

        public CoffObject(ByteSize size)
        {
            Data = Buffers.native(size);
        }

        public void Dispose()
        {
            Data.Dispose();
        }


        public struct SectionName
        {
            ByteBlock8 Data;
        }

        public struct FilePointer
        {
            uint Data;
        }

        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct SectionHeader
        {
            [Doc("An 8-byte, null-padded UTF-8 encoded string. If the string is exactly 8 characters long, there is no terminating null. For longer names, this field contains a slash (/) that is followed by an ASCII representation of a decimal number that is an offset into the string table")]
            public SectionName SectionName;

            [Doc("The total size of the section when loaded into memory. If this value is greater than SizeOfRawData, the section is zero-padded. This field is valid only for executable images and should be set to zero for object files")]
            public uint Size;

            [Doc("For executable images, the address of the first byte of the section relative to the image base when the section is loaded into memory. For object files, this field is the address of the first byte before relocation is applied; for simplicity, compilers should set this to zero. Otherwise, it is an arbitrary value that is subtracted from offsets during relocation.")]
            public Address32 VirtualAddress;

            [Doc("The size of the section (for object files) or the size of the initialized data on disk (for image files). For executable images, this must be a multiple of FileAlignment from the optional header. If this is less than VirtualSize, the remainder of the section is zero-filled. Because the SizeOfRawData field is rounded but the VirtualSize field is not, it is possible for SizeOfRawData to be greater than VirtualSize as well. When a section contains only uninitialized data, this field should be zero.")]
            public uint SizeOfRawData;

            [Doc("The file pointer to the first page of the section within the COFF file. For executable images, this must be a multiple of FileAlignment from the optional header. For object files, the value should be aligned on a 4-byte boundary for best performance. When a section contains only uninitialized data, this field should be zero.")]
            public FilePointer PointerToRawData;

            [Doc("The file pointer to the beginning of relocation entries for the section. This is set to zero for executable images or if there are no relocations.")]
            public FilePointer PointerToRelocations;

            [Doc("The file pointer to the beginning of line-number entries for the section. This is set to zero if there are no COFF line numbers. This value should be zero for an image because COFF debugging information is deprecated.")]
            public FilePointer PointerToLineNumbers;

            [Doc("The number of relocation entries for the section. This is set to zero for executable images.")]
            public ushort NumberOfRelocations;

            [Doc("The number of line-number entries for the section. This value should be zero for an image because COFF debugging information is deprecated.")]
            public ushort NumberOfLineNumbers;

            [Doc("The flags that describe the characteristics of the section")]
            public IMAGE_SECTION_CHARACTERISTICS Characteristics;
        }

        public struct StringTable
        {

        }

        public struct SymbolTable
        {
            readonly Ptr<SymbolTableEntry> FirstEntry;

            public readonly ushort EntryCount;

            [MethodImpl(Inline)]
            internal SymbolTable(Ptr<SymbolTableEntry> pFirst, ushort count)
            {
                FirstEntry = pFirst;
                EntryCount = count;
            }

            public ref SymbolTableEntry this[uint index]
            {
                [MethodImpl(Inline)]
                get => ref FirstEntry[index];
            }
        }

        public unsafe struct SectionData
        {
            MemoryAddress Address;

            public uint Size;

            public Span<byte> Content
            {
                [MethodImpl(Inline)]
                get => cover(Address.Pointer<byte>(), Size);
            }
        }

        public struct SymbolName
        {
            ByteBlock8 Data;

            public Span<byte> Content
            {
                [MethodImpl(Inline)]
                get => Data.Bytes;
            }

            public bit IsShort
            {
                [MethodImpl(Inline)]
                get => Data.Lo == 0;
            }

            public ref uint Offset
            {
                [MethodImpl(Inline)]
                get => ref Data.Hi;
            }
        }

        [StructLayout(LayoutKind.Sequential, Size=18, Pack=1)]
        public struct SymbolTableEntry
        {
            [Doc("The name of the symbol, represented by a union of three structures. An array of 8 bytes is used if the name is not more than 8 bytes long. For more information, see Symbol Name Representation.")]
            public SymbolName Name;

            [Doc("The value that is associated with the symbol. The interpretation of this field depends on SectionNumber and StorageClass. A typical meaning is the relocatable address")]
            public uint Value;

            [Doc("The signed integer that identifies the section, using a one-based index into the section table.")]
            public short SectionNumber;

            [Doc("A number that represents type. Microsoft tools set this field to 0x20 (function) or 0x0 (not a function)")]
            public ushort Type;

            [Doc("An enumerated value that represents storage class")]
            public byte StorageClass;

            [Doc("The number of auxiliary symbol table entries that follow this record.")]
            public byte NumberOfAuxSymbols;
        }
    }
}