//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;
    using static Root;

    public readonly struct AccessorCapture
    {
        readonly IAsmContext Context;

        [MethodImpl(Inline)]
        public static AccessorCapture Service(IAsmContext context)
            => new AccessorCapture(context);
        
        [MethodImpl(Inline)]
        internal AccessorCapture(IAsmContext context)
        {
            Context = context;
            DataRoot.Clear();
            ResBytesDir.Clear();
            AsmDst.Clear();
        }

        FolderPath DataRoot 
            => Context.AppPaths.AppDataRoot;

        FolderPath ResBytesDir
            => DataRoot + FolderName.Define("resbytes");

        FolderPath AsmDst
            => ResBytesDir + FolderName.Define("asm");
                

        public void CaptureResBytes()
        {
            var root = Context.AppPaths.LogRoot;
            var src = Context.AppPaths.ResBytes;            
            var provider = src.FileName;

            Demands.insist(src.Exists);
            var csvDst = ResBytesDir + provider.ChangeExtension(FileExtensions.Csv);
            var captured = Capture(src, AsmDst);
            CollectAddresses(captured, csvDst);
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
            var stores = ResourceStore.Service;
            var methods = span(stores.Accessors(assembly));            
            return Capture(methods, dst);
        }

        public CapturedAccessor[] Capture(FilePath src, FolderPath dst)        
        {
            var assembly = Assembly.LoadFrom(src.Name);  
            var store = ResourceStore.Service;
            var index = span(store.AccesorIndex(assembly));
            var results = Root.list<CapturedAccessor>();
            for(var i=0; i<index.Length; i++)
            {
                ref readonly var accessors =  ref Root.skip(index,i);
                var path = dst + FileName.Define(accessors.DeclaringType.Name, FileExtensions.Asm);
                var captured = Capture(accessors.Accessors, path);
                results.AddRange(captured);
            }
                            
            return results.ToArray();
        }

        public CapturedAccessor[] Capture(ReadOnlySpan<ResourceAccessor> src, FilePath outpath)
        {
            var captured = list<CapturedAccessor>();
            using var writer = outpath.Writer();
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
                        captured.Add(new CapturedAccessor(accessor,f.Value));
                }
            }
            return captured.ToArray();
        }
        public CapturedAccessor[] CaptureKnown(FilePath outpath)
        {
            var stores = ResourceStore.Service;
            var assemblies = Context.Api.Composition.Assemblies;
            var methods = span(stores.Accessors(assemblies));
            return Capture(methods, outpath);
        }

        public void CollectAddresses(ReadOnlySpan<CapturedAccessor> src, FilePath dst)
        {
            const ulong Cut = 0x55005500550;
            using var writer = dst.Writer();
            writer.WriteLine(text.concat("Addresss".PadRight(16),  " | ", "Accessor"));
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var accessor = ref skip(src, i);
                var f = accessor.Code.Function;
                var moves = AsmAnalyzer.moves(f);
                for(var j =0; j<moves.Length; j++)
                {
                    ref readonly var move = ref skip(moves,j);
                    var imm = move.Src;
                    if(imm < Cut)
                    {
                        var description = text.concat(move.Src.ToAddress().Format().PadRight(16), " | ", accessor.Code.Code.OpUri);
                        writer.WriteLine(description);
                    }
                }
            }            
        }
    }
}