//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.PortableExecutable;
    using System.IO;
    using System.Linq;
        
    using static Konst;    
            
    [ApiHost]
    public partial class ImgMetadataReader : IImgMetadataReader
    {
       readonly ReaderState State;

        [MethodImpl(Inline)]
        public static IImgMetadataReader open(FilePath src)
        {
            var stream = File.OpenRead(src.Name);
            var reader = new PEReader(stream);
            return new ImgMetadataReader(new ReaderState(stream, reader));
        }

        public static ReadOnlySpan<PeHeaderRecord> headers(FilePath src)        
        {
            using var stream = File.OpenRead(src.Name);
            using var reader = new PEReader(stream);

            var dst = Root.list<PeHeaderRecord>();
            var headers = reader.PEHeaders;

            var sections = headers.SectionHeaders;

            foreach(var section in sections)
            {                
                dst.Add(new PeHeaderRecord(src.FileName, 
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
 
        public static ReadOnlySpan<ImgMethodBody> methods(FilePath src)
        {
            var dst = Root.list<ImgMethodBody>();
            
            using var stream = File.OpenRead(src.Name);
            using var pe = new PEReader(stream);
            
            var reader = pe.GetMetadataReader();
            foreach(var handle in reader.TypeDefinitions)
            {
                 var definitions = z.map(reader.GetTypeDefinition(handle).GetMethods(), m => reader.GetMethodDefinition(m));
                
                 foreach(var definition in definitions)
                 {
                    var rva = definition.RelativeVirtualAddress;
                    if(rva != 0)
                    {
                        var body = pe.GetMethodBody(rva);
                        var sig = reader.GetBlobBytes(definition.Signature);   
                        var name = reader.GetString(definition.Name);                 
                        var il = body.GetILBytes();
                        dst.Add(new ImgMethodBody{Sig = sig, Name = name, Rva = (uint)rva, Cil = il});
                    }
                 }            
            }
            
            return dst.ToArray();
        }

        [MethodImpl(Inline)]
        ImgMetadataReader(ReaderState src)
            => State = src;
        
        public void Dispose()
            => State.Dispose();
                
        public ReadOnlySpan<ImgStringRecord> ReadStrings()
            => strings(State);

        public ReadOnlySpan<ImgStringRecord> ReadUserStrings()
            => ustrings(State);

        public ReadOnlySpan<ImgBlobRecord> ReadBlobs()
            => blobs(State);

        public ReadOnlySpan<ImgConstantRecord> ReadConstants()
            => constants(State);
            
        public ReadOnlySpan<ImgFieldRecord> ReadFields()
            => fields(State);     

        public ReadOnlySpan<ImgFieldRva> ReadFieldRva()
            => fieldrva(State);                 
    }
}