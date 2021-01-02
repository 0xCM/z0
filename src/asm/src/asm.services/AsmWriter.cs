//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static memory;

    public readonly struct AsmWriter : IAsmWriter
    {
        [MethodImpl(Inline), Op]
        public static AsmWriter create(FS.FilePath dst)
            => new AsmWriter(dst, new AsmFormatter());

        [MethodImpl(Inline), Op]
        public static AsmWriter create(FS.FilePath dst, in AsmFormatConfig config)
            => new AsmWriter(dst, new AsmFormatter(config));

        [MethodImpl(Inline), Op]
        public static AsmWriter create(FS.FilePath dst, IAsmFormatter formatter)
            => new AsmWriter(dst, formatter);

        public static FS.FilePath emit(IWfShell wf, ApiHostUri uri, ReadOnlySpan<AsmRoutine> src, in AsmFormatConfig format)
        {
            var count = src.Length;
            if(count != 0)
            {
                var path = wf.Db().CapturedAsmFile(uri);
                using var writer = path.Writer();
                var buffer = Buffers.text();

                for(var i=0; i<count; i++)
                {
                    ref readonly var routine = ref skip(src,i);
                    AsmRender.format(routine, format, buffer);
                    writer.Write(buffer.Emit());
                }
                return path;
            }
            else
                return FS.FilePath.Empty;
        }

        public static void emit(ReadOnlySpan<CapturedApiRes> src, FS.FilePath dst)

        {
            const ulong Cut = 0x55005500550;
            const string Sep = SpacePipe;
            const string StartMsg = "Emitting captured resource disassembly";
            const string Col0 = "Addresses";
            const string Col1 = "Accessor";
            const ushort Col0Width = 16;

            var capcount = src.Length;
            using var writer = dst.Writer();
            writer.WriteLine(text.concat(Col0.PadRight(Col0Width), Sep, Col1));

            for(var i=0u; i<capcount; i++)
            {
                ref readonly var captured = ref skip(src, i);

                var code = captured.Code;
                var host = captured.ApiHost;
                var accessor = captured.Accessor;
                var uri = OpUri.hex(host, accessor.Member.Name, code.Code.MemberId);

                var moves = AsmAnalyzer.moves(code.Routine);
                var movecount = moves.Length;
                for(var j=0u; j<movecount; j++)
                {
                    ref readonly var move = ref skip(moves,j);

                    if(move.Source < Cut)
                        writer.WriteLine(text.concat(move.Source.ToAddress().Format().PadRight(Col0Width), Sep, uri));
                }
            }
        }

        readonly StreamWriter StreamOut;

        readonly IAsmFormatter Formatter;

        public FS.FilePath TargetPath {get;}

        [MethodImpl(Inline)]
        public AsmWriter(FilePath path, IAsmFormatter formatter)
        {
            TargetPath = FS.path(path.Name);
            Formatter = formatter;
            StreamOut = new StreamWriter(path.CreateParentIfMissing().FullPath,false);
        }

        [MethodImpl(Inline)]
        public AsmWriter(FS.FilePath path, IAsmFormatter formatter)
        {
            TargetPath = path;
            Formatter = formatter;
            StreamOut = path.Writer();
        }

        public void WriteAsm(params AsmRoutine[] src)
        {
            foreach(var f in src)
                StreamOut.Write(Formatter.FormatFunction(f));
        }

        public void Dispose()
        {
            StreamOut.Flush();
            StreamOut.Dispose();
        }
    }
}