//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Seed;

    readonly struct AsmCodeWriter : IAsmCodeWriter
    {        
        readonly StreamWriter StreamOut;

        public FilePath TargetPath {get;}


        [MethodImpl(Inline)]
        public static IAsmCodeWriter New(IContext context, FilePath dst)
            => new AsmCodeWriter(dst);

        [MethodImpl(Inline)]
        AsmCodeWriter(FilePath path)
        {
            this.TargetPath = path;
            this.StreamOut = new StreamWriter(path.CreateParentIfMissing().FullPath,false);
        }

        public void WriteCode(in AsmCode src, int? idpad = null)
        {
            StreamOut.WriteLine(src.Format(idpad ?? 0));
        }
        
        public void WriteDiagnostic(in CapturedOp src)
        {
            var data = src.Code;
            var dst = text.build();
			dst.AppendLine($"; label   : {src.OpSig}");
			dst.AppendLine($"; location: {src.AddressRange.Format()}, length: {src.AddressRange.Length} bytes");
            var lines = data.Bytes.FormatHexLines(null);
            dst.Append(lines.Concat(Chars.Eol));
            dst.AppendLine(new string('_',80));
            StreamOut.Write(dst.ToString());
        }

        public void WriteHexLine(in CapturedOp src, int? idpad = null)
            => StreamOut.WriteLine(AsmHexLine.Define(src.OpId, src.RawBits.Bytes).Format(idpad ?? 0)); 

        public void Write(AsmCode[] src)
        {
            var idpad = src.Max(x => x.Id.Identifier.Length) + 1;
            for(var i=0; i< src.Length; i++)
            {
                WriteCode(src[i], idpad);
            }
        
            StreamOut.Flush();
        }
        public void Dispose()
        {
            StreamOut.Flush();
            StreamOut.Dispose();
        }
    }
}