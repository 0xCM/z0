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
    using static EmitResBytesStep;
    using static z;

    public readonly struct EmitResBytesStep
    {
        public const string WorkerName = nameof(EmitResBytes);
    }

    [Step(WfStepId.EmitResBytes)]
    public readonly ref struct EmitResBytes
    {            
        const string ProjectName = "bytes";

        readonly IEncodedHexArchive Archive;

        public readonly FolderPath SourceDir;

        public readonly FolderPath TargetDir;
                
        readonly WfContext Wf;

        readonly CorrelationToken Ct;

        IWfEventSink Sink 
            => Wf.Broker.Sink;        
        
        [MethodImpl(Inline)]
        public static EmitResBytes create(WfContext context, CorrelationToken? ct = null)
            => new EmitResBytes(context, ct);

        internal EmitResBytes(WfContext context, CorrelationToken? ct = null)
        {
            Wf = context;
            Ct = ct ?? CorrelationToken.create();
            SourceDir = context.AppPaths.AppCaptureRoot;
            TargetDir = context.AppPaths.ResourceRoot + FolderName.Define(ProjectName);
            Archive = Archives.Services.EncodedHexArchive(SourceDir);            
            Wf.Created(WorkerName,Ct);
        }
        
        public void Run()        
        {
            Wf.RunningT(WorkerName, new {SourceDir, TargetDir}, Ct);
            
            var indices = CodeReader.identified(SourceDir, Sink);
            
            foreach(var index in indices)
            {
                Wf.Status(WorkerName, $"Loaded {index.Code.Length} {index.Host} code blocks", Ct);
                try
                {
                    Emit(index, TargetDir);
                }
                catch(Exception e)
                {
                    Wf.Error(e, Ct);
                }
            }
        }

        public void Dispose()
        {
            Wf.Finished(WorkerName, Ct);
        }

        void Emit(IdentifiedCodeIndex src, FolderPath dst)
        {
            var path = (dst + FolderName.Define("src")) + src.Host.FileName(FileExtensions.Cs);            
            var resources = DefineResources(src);
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
                    EmitMember(writer, Render(res));
                    members.Add(res.Identifier);
                }
                
            }
            CloseTypeDeclaration(writer);
            CloseFileNamespace(writer);
            
            Wf.Raise(new EmittedHostBytes(src.Host, (ushort)resources.Count, Ct));
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

        static HostResources DefineResources(IdentifiedCodeIndex src)
        {                        
            var count = src.Code.Length;
            var res = alloc<BinaryResourceSpec>(count);
            for(var i=0; i<count; i++)
            {
                res[i] = DefineResource(src.Code[i]);
            }            
            return new HostResources(src.Host,res);
        }

        HostResources DefineResources(IEncodedHexArchive archive, ApiHostUri host)
        {            
            var code = archive.Read(host).ToArray();
            var res = alloc<BinaryResourceSpec>(code.Length);
            for(var i=0; i<code.Length; i++)
            {
                res[i] = DefineResource(code[i]);
            }            
            return new HostResources(host,res);
        }

        static BinaryResourceSpec DefineResource(IdentifiedCode src)
            => new BinaryResourceSpec(src.Id.ToPropertyName(), src.Encoded);
    }

}