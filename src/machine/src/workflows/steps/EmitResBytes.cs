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
    
    [Step(WfStepId.EmitResBytes)]
    public readonly ref struct EmitResBytes
    {            
        const string ProjectName = "bytes";

        readonly IEncodedHexArchive Source;

        readonly FolderPath Target;
        
        readonly WfContext Wf;

        readonly CorrelationToken Correlation;
        
        [MethodImpl(Inline)]
        public static EmitResBytes create(WfContext context, CorrelationToken? ct = null)
            => new EmitResBytes(context, ct);

        internal EmitResBytes(WfContext context, CorrelationToken? ct = null)
        {
            Wf = context;
            Correlation = ct ?? CorrelationToken.create();
            Source = Archives.Services.EncodedHexArchive(context.AppPaths.AppCaptureRoot);            
            Target = context.AppPaths.ResourceRoot + FolderName.Define(ProjectName);
            Wf.Running(text.format("Running {0} workflow {1} -> {2}", nameof(EmitResBytes), Source.ArchiveRoot, Target));
        }
        
        public void Run()        
        {
            var indices = Source.ReadIndices().ToArray();
            Wf.Status($"Loaded {indices.Length} encoded hex files");

            foreach(var index in indices)
                emit(index, Target);
        }

        public void Dispose()
        {
            Wf.Status(text.format("Ran {0} workflow", nameof(EmitResBytes)));
        }

        void emit(IdentifiedCodeIndex src, FolderPath dst)
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
            Wf.Raise(new EmittedHostBytes(src.Host, (ushort)resources.Count));
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