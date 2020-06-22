//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using static CodeGenerator;

    using static Konst;
    using static Root;

    public readonly struct HostCodeResource
    {
        readonly IEncodedHexArchive Source;

        readonly FolderPath Target;

        
        public static HostCodeResource Service(FolderPath src, FolderPath dst) 
            => new HostCodeResource(src,dst);

        public HostCodeResource(FolderPath src, FolderPath dst)
        {
            Source = Archives.Services.HexArchive(src);
            
            Target = dst;
        }
        
        
        public void Emit(params PartId[] src)        
        {
            var indices = Source.ReadIndices(src).ToArray();
            term.print($"Loaded {indices.Length} encoded hex files for {src}");

            foreach(var index in indices)
                Emit(index);
        }
        
        public void Emit(IdentifiedCodeIndex src)
        {
            var path = Target + src.Host.FileName(FileExtensions.Cs);            
            var resources = Specify(src);
            var typename = text.concat(src.Host.Owner.Format(), Chars.Underscore, src.Host.Name);
            using var dst = path.Writer();
            EmitFileHeader(dst);
            OpenFileNamespace(dst, "Z0.ByteCode");
            EmitUsingStatments(dst);
            DeclareStaticClass(dst, typename);
            for(var i=0; i<resources.Count; i++)
            {
                ref readonly var res = ref resources[i];
                EmitMember(dst, Render(res));
                //dst.WriteLine(Render(res));
            }
            CloseTypeDeclaration(dst);
            CloseFileNamespace(dst);

            term.print($"Emitted {resources.Count} resource definitions to {path}");
        }

        static string Render(BinaryResourceSpec src, int level = 2)
            => text.concat("public static ReadOnlySpan<byte> ", 
            src.Identifier, 
            Space,
            " => ", 
            Space,
            $"new byte[{src.Encoded.Length}]",
            LBrace, 
            src.Encoded.Format(HexFormatConfig.ArrayContent), 
            RBrace,
            Chars.Semicolon
            );

        HostResourceSpec Specify(IdentifiedCodeIndex src)
        {                        
            var count = src.Code.Length;
            var res = alloc<BinaryResourceSpec>(count);
            for(var i=0; i<count; i++)
            {
                res[i] = Specify(src.Code[i]);
            }            
            return new HostResourceSpec(src.Host,res);
        }

        HostResourceSpec Specify(ApiHostUri src)
        {            
            var code = Source.Read(src).ToArray();
            var res = alloc<BinaryResourceSpec>(code.Length);
            for(var i=0; i<code.Length; i++)
            {
                res[i] = Specify(code[i]);
            }            
            return new HostResourceSpec(src,res);
        }

        static BinaryResourceSpec Specify(IdentifiedCode src)
            => new BinaryResourceSpec(src.Id.ToPropertyName(), src.Encoded);
    }
}