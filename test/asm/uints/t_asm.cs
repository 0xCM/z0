//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    using static Seed;
    using static Memories;
    
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using R = Z0.Parts;

    public abstract class t_asm<U> : UnitTest<U,CheckVectors,ICheckVectors>
        where U : t_asm<U>
    {
     
        protected void WriteHex(ApiMemberCapture captured, StreamWriter dst)
        {
            var xLineFormatter = HexLineFormatter.Create();
            var parsed = captured.Parsed;
			dst.WriteLine($"; label   : {captured.OpSig}");
			dst.WriteLine($"; location: {captured.AddressRange.Format()}, length: {captured.AddressRange.Length} bytes");
            var lines = xLineFormatter.FormatHexLines(parsed.Bytes);
            iter(lines, line => dst.WriteLine(line));            
            dst.WriteLine(new string('_',80));

        }
     
        protected void WriteAsm(ApiMemberCapture capture, StreamWriter dst)
        {
            //var parsed = capture.Parsed;
			// dst.WriteLine($"; label   : {capture.OpSig}");
			// dst.WriteLine($"; location: {capture.AddressRange.Format()}, length: {capture.AddressRange.Length} bytes");
            var asm = Context.Decoder.Decode(capture).Require();
            var formatted = Context.Formatter.FormatFunction(asm);
            dst.WriteLine(formatted);            
        }

        protected ICaptureArchive CodeArchive 
            => Context.CaptureArchive(
                Env.Current.LogDir + FolderName.Define("test"), 
                FolderName.Define("data"), 
                FolderName.Define(typeof(U).Name)
                );
        
        protected StreamWriter FileStreamWriter([Caller] string caller = null)
            => CodeArchive.HexPath(FileName.Define(caller)).Writer();


        protected new IAsmContext Context;
        
        public static IPart[] DefaultResolutions 
            => new IPart[]{
                R.Blocks.Resolved, 
                R.Math.Resolved,
                R.Vectors.Resolved,
                R.GMath.Resolved,
                R.Cast.Resolved
                }
                ;        
        public t_asm()
        {
            Context = AsmContext.Create(
                AppSettings.Empty, 
                Queue, 
                ApiComposition.Assemble(DefaultResolutions), 
                Env.Current.LogDir,
                AsmFormatConfig.DefaultStreamFormat
                );
        }
    }
}