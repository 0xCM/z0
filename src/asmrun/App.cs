//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using Asm;

    using static memory;
    using static Part;
    using static Sigs;

    using Code = Z0.ByteCode;

    public unsafe class App : WfService<App>
    {
        ApiResProvider ResProvider;

        ApiCaptureRunner CaptureRunner;

        protected override void OnInit()
        {
            ResProvider = Wf.ApiResProvider();
            CaptureRunner = Wf.CaptureRunner();
        }

        public static ReadOnlySpan<byte> Store4 => new byte[4]{0x8D, 0x04, 0x11, 0xc3}; // lea eax, [rcx+rdx] | ret


        void CaptureMe()
        {
            var parts = root.array(PartId.AsmRun);
            var dst = Db.AppLogDir() + FS.folder("capture");
            dst.Clear();
            CaptureRunner.Capture(parts, dst);

        }

        void EmitContext()
        {
            Wf.ProcessContextEmitter().Emit(Db.ImageDumpRoot());
        }


        void Run()
        {
            SigClient.run();
            CaptureMe();
            EmitContext();

        }

        public static void Main(params string[] args)
        {
            try
            {
                using var wf = WfRuntime.create(ApiCatalogs.parts(Index<PartId>.Empty), args).WithSource(Rng.@default());
                var app = App.create(wf);
                app.Run();

            }
            catch(Exception e)
            {
                term.error(e);
            }
        }

        void EmitByteCode()
        {
            var package = Db.Package("respack");
            var path = package + FS.file("z0.respack.dll");
            var exists = path.Exists ? "Exists" : "Missing";
            Wf.Status($"{path} | {exists}");
            var assembly = Assembly.LoadFrom(path.Name);
            var provider = Wf.ApiResProvider();
            var accessors = provider.PackagedCode().View;
            var count = accessors.Length;
            var dst = Db.AppLog("respack", FS.Asm);
            var decoder = Wf.AsmDecoder();
            var buffer = text.buffer();
            var sequence = 0u;
            var segments = root.list<MemorySegment>(30000);
            using var writer = dst.Writer();
            using var hexout = dst.ChangeExtension(FS.Hex).Writer();
            for(var i=0; i<count; i++)
            {
                var seqlabel = sequence.ToString("d6") + ": ";
                ref readonly var accessor = ref skip(accessors,i);
                var raw = Resources.definition(accessor).ToArray();
                var bytes = @readonly(raw);
                var decoded = decoder.Decode(raw, MemoryAddress.Zero).View;
                var name = accessor.DeclaringType.Name + "/" + accessor.Member.Name;
                writer.WriteLine(asm.comment(seqlabel + name));
                AsmFormatter.render(raw,decoded,buffer);
                writer.Write(buffer.Emit());

                var offset = z16;
                var mov = AsmHexCode.Empty;
                var movsize = AsmHexCode.Empty;
                hexout.Write(seqlabel);
                for(var j=0; j<decoded.Length; j++)
                {
                    ref readonly var fx = ref skip(decoded,j);
                    var size = (byte)fx.ByteLength;
                    var code = AsmBytes.hexcode(slice(bytes,offset,size));

                    if(j !=0)
                        hexout.Write(Chars.Space);
                    hexout.Write(code.Format());
                    if(size == 10)
                        mov = code;
                    else if(size == 7)
                        movsize = code;
                    offset += size;
                }

                var imm64 = Imm64.from(slice(mov.Bytes,2));
                var imm32 = Imm32.from(slice(movsize.Bytes,3));
                hexout.Write(string.Format(" ## {0:X} ## {1:X}", imm64, imm32));
                hexout.WriteLine();

                segments.Add(Resources.capture(accessor));

                sequence++;
            }

            using var proplog = Db.AppLog("respack.props").Writer();
            foreach(var prop in segments)
            {
                proplog.WriteLine(string.Format("{0}[{1}]:{2}", prop.BaseAddress, prop.Size, prop.Buffer.FormatHex()));
            }
        }
    }
}