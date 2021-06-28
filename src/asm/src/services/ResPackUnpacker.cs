//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;
    using static core;

    public class ResPackUnpacker : AppService<ResPackUnpacker>
    {
        public void Emit(FS.FolderPath dst)
        {
            var asmpath = dst + FS.file("respack",FS.Asm);
            var hexpath = asmpath.ChangeExtension(FS.Hex);
            var provider = Wf.ApiResProvider();
            var path = provider.ResPackPath();
            var assembly = Assembly.LoadFrom(path.Name);
            var accessors = provider.ResPackAccessors();
            var count = accessors.Length;
            var decoder = Wf.AsmDecoder();
            var buffer = TextTools.buffer();
            var sequence = 0u;
            var segments = list<MemorySeg>(30000);
            var asmFlow = Wf.EmittingFile(asmpath);
            var hexFlow = Wf.EmittingFile(hexpath);
            using var asmwriter = asmpath.Writer();
            using var hexwriter = hexpath.Writer();
            for(var i=0; i<count; i++)
            {
                var seqlabel = sequence.ToString("d6") + ": ";
                ref readonly var accessor = ref skip(accessors,i);
                var raw = SpanRes.definition(accessor).ToArray();
                var bytes = @readonly(raw);
                var decoded = decoder.Decode(raw, MemoryAddress.Zero).View;
                var name = accessor.DeclaringType.Name + "/" + accessor.Member.Name;
                asmwriter.WriteLine(asm.comment(seqlabel + name));
                AsmFormatter.render(raw, decoded, buffer);
                asmwriter.Write(buffer.Emit());

                var offset = z16;
                var mov = AsmHexCode.Empty;
                var movsize = AsmHexCode.Empty;
                hexwriter.Write(seqlabel);
                for(var j=0; j<decoded.Length; j++)
                {
                    ref readonly var fx = ref skip(decoded,j);
                    var size = (byte)fx.ByteLength;
                    var code = AsmHexCode.load(slice(bytes,offset,size));

                    if(j !=0)
                        hexwriter.Write(Chars.Space);
                    hexwriter.Write(code.Format());
                    if(size == 10)
                        mov = code;
                    else if(size == 7)
                        movsize = code;
                    offset += size;
                }

                var imm64 = Imm64.from(slice(mov.Bytes, 2));
                var imm32 = Imm32.from(slice(movsize.Bytes, 3));
                hexwriter.Write(string.Format(" ## {0:X} ## {1:X}", imm64, imm32));
                hexwriter.WriteLine();

                segments.Add(ResourceCapture.capture(accessor));
                sequence++;
            }

            Wf.EmittedFile(asmFlow, sequence);
            Wf.EmittedFile(hexFlow, sequence);

            EmitProps(segments.ViewDeposited(), dst + FS.file("respack.data", FS.XPack));
        }

        void EmitProps(ReadOnlySpan<MemorySeg> src, FS.FilePath dst)
        {
            var flow= Wf.EmittingFile(dst);
            var count = src.Length;
            var buffer = alloc<char>(Pow2.T16);
            using var writer = dst.Writer();
            for(var i=0u; i<count; i++)
            {
                ref readonly var seg = ref skip(src,i);
                buffer.Clear();
                writer.WriteLine(HexPacks.linepack(seg,i, buffer));
            }
            Wf.EmittedFile(flow, count);
        }
    }
}