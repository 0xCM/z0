//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static CodeGenerator;
    using static Konst;
    using static z;
    
    public readonly struct EmitResBytes : IWorkflowStep<EmitResBytes>
    {
        public static WorkflowIdentity Identity
        {
            [MethodImpl(Inline)]
            get => WorkflowIdentity.define<EmitResBytes>(PartId.Machine);
        }
        
        const string ProjectName = "bytes";

        readonly IEncodedHexArchive Source;

        readonly FolderPath Target;
        
        [MethodImpl(Inline)]
        public static EmitResBytes configure(IAppContext context,  FolderPath src = null, FolderPath dst = null)
            => new EmitResBytes(src ?? context.AppPaths.CaptureRoot, dst ?? context.AppPaths.ResourceRoot + FolderName.Define(ProjectName));

        [MethodImpl(Inline)]
        public EmitResBytes Configure(IAppContext context,  FolderPath src = null, FolderPath dst = null)
            => configure(context, src, dst);

        EmitResBytes(FolderPath src, FolderPath dst)
        {
            Source = Archives.Services.EncodedHexArchive(src);            
            Target = dst;
        }
        
        public void Run(params string[] args)        
        {
            var indices = Source.ReadIndices().ToArray();
            term.print($"Loaded {indices.Length} encoded hex files");

            foreach(var index in indices)
                emit(index, Target);
        }

        static void emit(IdentifiedCodeIndex src, FolderPath dst)
        {
            var path = (dst + FolderName.Define("src")) + src.Host.FileName(FileExtensions.Cs);            
            var resources = specify(src);
            var typename = text.concat(src.Host.Owner.Format(), Chars.Underscore, src.Host.Name);
            var members = new HashSet<string>();
            using var writer = path.Writer();
            EmitFileHeader(writer);
            OpenFileNamespace(writer, "Z0.ByteCode");
            EmitUsingStatments(writer);
            DeclareStaticClass(writer, typename);
            for(var i=0; i<resources.Count; i++)
            {
                ref readonly var res = ref resources[i];
                if(!members.Contains(res.Identifier))
                {
                    EmitMember(writer, render(res));
                    members.Add(res.Identifier);
                }
                
            }
            CloseTypeDeclaration(writer);
            CloseFileNamespace(writer);
            term.print($"Emitted {resources.Count} resource definitions to {path}");
        }

        static string render(BinaryResourceSpec src, int level = 2)
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

        static HostResources specify(IdentifiedCodeIndex src)
        {                        
            var count = src.Code.Length;
            var res = alloc<BinaryResourceSpec>(count);
            for(var i=0; i<count; i++)
            {
                res[i] = specify(src.Code[i]);
            }            
            return new HostResources(src.Host,res);
        }

        static HostResources specify(IEncodedHexArchive archive, ApiHostUri host)
        {            
            var code = archive.Read(host).ToArray();
            var res = alloc<BinaryResourceSpec>(code.Length);
            for(var i=0; i<code.Length; i++)
            {
                res[i] = specify(code[i]);
            }            
            return new HostResources(host,res);
        }

        static BinaryResourceSpec specify(IdentifiedCode src)
            => new BinaryResourceSpec(src.Id.ToPropertyName(), src.Encoded);
    }
}