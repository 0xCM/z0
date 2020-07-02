//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata.Ecma335;
    using System.Reflection.Metadata;
    using System.Reflection.PortableExecutable;
    using System.IO;
    using System.Linq;
        
    using static Konst;    
    using static PartRecords;

    using F = HeaderField;

    public enum HeaderField : uint
    {
        FileName = 0 | (26 << WidthOffset),

        Section = 1 | (10 << WidthOffset),

        Address = 2 | (16 << WidthOffset),

        Size = 3 | (8 << WidthOffset),
        
        EntryPoint = 4 | (16 << WidthOffset),

        CodeBase = 5 | (16 << WidthOffset),

        GlobalPointerTable = 6 | (16 << WidthOffset),

        GlobalPointerTableSize = 7 | (8 << WidthOffset)

    }
    
    public readonly struct HeaderInfo
    {
        public readonly FileName FileName;

        public readonly string Section;

        public readonly MemoryAddress Address;

        public readonly ByteSize Size;

        public readonly MemoryAddress EntryPoint;

        public readonly MemoryAddress CodeBase;

        public readonly MemoryAddress GlobalPointerTable;

        public readonly ByteSize GlobalPointerTableSize;

        public HeaderInfo(FileName FileName, string Section, MemoryAddress Address, ByteSize Size, MemoryAddress EntryPoint, 
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

        public static void format(in HeaderInfo src, IDatasetFormatter<F> dst, bool eol = true)
        {
            dst.Delimit(F.FileName, src.FileName);
            dst.Delimit(F.Section, src.Section);
            dst.Delimit(F.Address, src.Address);
            dst.Delimit(F.Size, src.Size);
            dst.Delimit(F.EntryPoint, src.EntryPoint);
            dst.Delimit(F.CodeBase, src.CodeBase);
            dst.Delimit(F.GlobalPointerTable, src.GlobalPointerTable);
            dst.Delimit(F.GlobalPointerTableSize, src.GlobalPointerTableSize);
            if(eol)
                dst.EmitEol();            
        }

        public static Span<string> render(ReadOnlySpan<HeaderInfo> src)
        {
            var dst = Spans.alloc<string>(src.Length + 1);
            var formatter = Formatter;
            Root.head(dst) = formatter.HeaderText;
            for(var i=1; i<dst.Length; i++)
            {
                format(Root.skip(src,i - 1), formatter,false);
                Root.seek(dst,i) = formatter.Render();
            }
            return dst;
        }

        public static IDatasetFormatter<F> Formatter 
            => DatasetFormatter<F>.Default;
    }
    public class MethodBodyInfo
    {
        public string Name {get;set;}
        public Address32 Rva {get;set;}

        public BinaryCode Cil {get;set;}
    }
    
    [ApiHost]
    public partial class PartReader : IPartReader
    {
        [MethodImpl(Inline)]
        public static IPartReader open(FilePath src)
        {
            var stream = File.OpenRead(src.Name);
            var reader = new PEReader(stream);
            return new PartReader(new ReaderState(stream, reader));
        }

        public static ReadOnlySpan<HeaderInfo> headers(FilePath src)        
        {
            using var stream = File.OpenRead(src.Name);
            using var reader = new PEReader(stream);

            var dst = Root.list<HeaderInfo>();
            var headers = reader.PEHeaders;

            var sections = headers.SectionHeaders;


            foreach(var section in sections)
            {                
                dst.Add(new HeaderInfo(src.FileName, 
                    Section: section.Name, 
                    Address: (MemoryAddress)section.PointerToRawData, 
                    Size: section.SizeOfRawData,  
                    EntryPoint: (MemoryAddress)headers.PEHeader.AddressOfEntryPoint, 
                    CodeBase: (MemoryAddress)headers.PEHeader.BaseOfCode,
                    GlobalPointerTable: (MemoryAddress)headers.PEHeader.GlobalPointerTableDirectory.RelativeVirtualAddress,
                    GlobalPointerTableSize: (ByteSize)headers.PEHeader.GlobalPointerTableDirectory.Size
                 ));
            }
            
            return dst.ToArray();
        }
 
        public static ReadOnlySpan<MethodBodyInfo> methods(FilePath src)
        {
            var dst = Root.list<MethodBodyInfo>();
            using var stream = File.OpenRead(src.Name);
            using var pexe = new PEReader(stream);
            
            var reader = pexe.GetMetadataReader();
            foreach(var handle in reader.TypeDefinitions)
            {
                 var definitions = Root.map(reader.GetTypeDefinition(handle).GetMethods(), 
                    m => reader.GetMethodDefinition(m));
                
                 foreach(var md in definitions)
                 {
                    var rva = md.RelativeVirtualAddress;
                    if(rva != 0)
                    {
                        var body = pexe.GetMethodBody(rva);

                        var info = new MethodBodyInfo{
                            Name = reader.GetString(md.Name),
                            Rva = (uint)rva,
                            Cil = body.GetILBytes()
                            };
                        dst.Add(info);
                    }

                 }            
            }
            
            return dst.ToArray();
        }

        static MetadataRootBuilder build()
            => new MetadataRootBuilder(new MetadataBuilder());

        readonly ReaderState State;

        [MethodImpl(Inline)]
        PartReader(ReaderState src)
            => State = src;
        
        public void Dispose()
            => State.Dispose();
                
        [MethodImpl(Inline)]
        public ReadOnlySpan<R> Read<R>()
            where R : struct, IPartRecord
                => read<R>(State);

        public ReadOnlySpan<StringValueRecord> ReadStrings()
            => strings(State);

        public ReadOnlySpan<StringValueRecord> ReadUserStrings()
            => ustrings(State);

        public ReadOnlySpan<BlobRecord> ReadBlobs()
            => blobs(State);

        public ReadOnlySpan<ConstantRecord> ReadConstants()
            => constants(State);
            
        public ReadOnlySpan<FieldRecord> ReadFields()
            => fields(State);     

        public ReadOnlySpan<FieldRvaRecord> ReadFieldRva()
            => fieldrva(State);                 
    }
}