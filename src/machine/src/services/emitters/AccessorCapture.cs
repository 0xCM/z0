//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Reflection;

    using Z0.Asm;

    using static Konst;
    using static Root;

    public interface IAccessorCapture : IContextual<IAppContext>
    {
        FolderPath ResBytesDir
            => Context.AppPaths.AppDataRoot + FolderName.Define("resbytes");

        /// <summary>
        /// The x86 resource assembly output path - which was created by disassembling most of z0
        /// </summary>
        FilePath ResBytesCompiled
            => FilePath.Define(@"J:\dev\projects\z0-logs\res\bin\lib\netcoreapp3.0\z0.res.dll");

        /// <summary>
        /// The target directory that receives data obtained by disassembling the resource disassembly file <see cref='ResBytesCompiled'/>
        /// </summary>
        FolderPath ResBytesUncompiled
            => ResBytesDir + FolderName.Define("asm");                

    }
    
    public readonly struct AccessorCapture : IAccessorCapture
    {
        readonly IAsmContext Context;
        
        IAppContext IContextual<IAppContext>.Context 
            => Context.ContextRoot;

        IAccessorCapture This => this;

        FolderPath ResBytesDir
            => This.ResBytesDir;

        FilePath ResBytesCompiled
            => This.ResBytesCompiled;

        FolderPath ResBytesUncompiled
            => This.ResBytesUncompiled;

        [MethodImpl(Inline)]
        public AccessorCapture(IAsmContext context)
        {
            Context = context;            
            Context.AppPaths.AppDataRoot.Clear();
            ResBytesDir.Clear();
            ResBytesUncompiled.Clear();
        }
                        
        public void CaptureResBytes()
        {            
            var resfile = z.insist(ResBytesCompiled);
            var captured = Capture(resfile, ResBytesUncompiled);            
            var csvfile = ResBytesDir + resfile.FileName.ChangeExtension(FileExtensions.Csv);            
            CollectAddresses(captured, csvfile);
        }

        void WriteAsm(CapturedCode capture, StreamWriter dst)
        {
            var asm = Context.Decoder.Decode(capture).Require();
            var formatted = Context.Formatter.FormatFunction(asm);
            dst.Write(formatted);            
        }

        Option<AsmFunctionCode> FunctionCode(CapturedCode capture)
        {
            var decoded = Context.Decoder.Decode(capture);
            if(decoded)
                return new AsmFunctionCode(decoded.Value, capture);
            else
                return Option.none<AsmFunctionCode>();
        }

        public CapturedAccessor[] Capture(FilePath src, FilePath dst)        
        {
            var assembly = Assembly.LoadFrom(src.Name);  
            return Capture(Resources.accessors(assembly), dst);
        }

        public CapturedAccessor[] Capture(FilePath respath, FolderPath dst)        
        {
            var resdll = Assembly.LoadFrom(respath.Name);  
            var indices = span(Resources.declarations(resdll));
            var idxcount = indices.Length;

            term.magenta($"Capturing {idxcount} host resource sets from {respath} -> {dst}");

            var results = z.list<CapturedAccessor>();
            for(var i=0u; i<idxcount; i++)
            {
                ref readonly var index = ref z.skip(indices,i);            
                var typename = index.DeclaringType.Name;
                var part = PartIdParser.parse(typename.LeftOf('_'))[0];
                var host = typename.RightOf('_');
                var hosturi = ApiHostUri.Define(part, host);
                var asmpath = dst + hosturi.FileName(FileExtensions.Asm);
                results.AddRange(Capture(index.Data, asmpath));
            }

            term.magenta($"Captured {results.Count} {respath.FileName} acessors");

            return results.ToArray();
        }

        public CapturedAccessor[] CaptureKnown(FilePath outpath)
        {
            var assemblies = Context.Api.Composition.Assemblies;
            return Capture(Resources.accessors(assemblies), outpath);
        }

        public CapturedAccessor[] Capture(ReadOnlySpan<ResourceAccessor> src, FilePath asmpath)
        {
            var captured = list<CapturedAccessor>();
            using var writer = asmpath.Writer();
            using var capture = QuickCapture.Alloc(Context);
            
            var dst = span(alloc<CapturedCode>(src.Length));
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var accessor = ref skip(src,i);
                var result = capture.Capture(accessor.Member);
                seek(dst,i) = result.ValueOrDefault(CapturedCode.Empty);
                
                if(result)
                {
                    ref readonly var code = ref skip(dst,i);
                    WriteAsm(code, writer);
                    
                    var f = FunctionCode(code);
                    if(f)
                        captured.Add(new CapturedAccessor(accessor, f.Value));
                }
            }
            return captured.ToArray();
        }
        
        public void CollectAddresses(ReadOnlySpan<CapturedAccessor> src, FilePath dst)
        {
            const ulong Cut = 0x55005500550;
            
            const string Col0 = "Addresses";
            const string Col1 = "Accessor";            
            const ushort Col0Width = 16;
            const ushort Col1Width = 180;
            const string Sep = SpacePipe;

            var capcount = src.Length;

            term.magenta($"Emitting resbytes disassembly catalog to {dst}");

            using var writer = dst.Writer();
            writer.WriteLine(text.concat(Col0.PadRight(Col0Width), Sep, Col1));
            
            for(var i=0u; i<capcount; i++)
            {
                ref readonly var captured = ref z.skip(src, i);
                var code = captured.Code;
                var function = code.Function;
                var accessor = captured.Accessor;
                var part = accessor.DeclaringType.Assembly.Id();
                
                var moves = AsmAnalyzer.moves(function);                
                var movcount = moves.Length;
                
                for(var j=0u; j<movcount; j++)
                {
                    ref readonly var move = ref z.skip(moves,j);
                    var imm = move.Src;
                    if(imm < Cut)
                    {
                        var loc = move.Src.ToAddress();
                        var uri = captured.Code.Code.OpUri;                        
                        var description = text.concat(loc.Format().PadRight(Col0Width), Sep, uri);                        
                        writer.WriteLine(description);
                    }
                }
            } 

            term.magenta($"Emitted resbytes disassembly");

        }
    }
}