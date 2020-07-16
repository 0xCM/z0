//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.IO;

    public interface TAsmTester : 
        IService<IAsmContext>, 
        IBufferedChecker, 
        ITestDynamic, 
        TCheckVectors, 
        ICheckCapture 
    {        
        IAsmFunctionDecoder Decoder 
            => Context.Decoder; 

        IAsmFormatter Formatter 
            => Context.Formatter;

        IUriHexQuery UriBitQuery 
            => Z0.UriHexQuery.Service;

        TArchives Archives 
            => Z0.Archives.Services;

        IPolyrand IPolyrandProvider.Random 
            => Context.Random;

        ICaptureCore ICaptureServiceProxy.CaptureService 
            => Context.CaptureCore;        

        TPartCaptureArchive CaptureArchive(PartId part)
            => Archives.CaptureArchive(
                (Env.Current.LogDir + FolderName.Define("apps")) + FolderName.Define(part.Format()), 
                FolderName.Define("capture"));

        TPartCaptureArchive CaptureArchive(FolderPath root)
            => Archives.CaptureArchive(root, null, null);

        FilePath AsmFilePath<T>(PartId part) 
            => CaptureArchive(part).AsmPath<T>();

        FilePath HexFilePath<T>(PartId part) 
            => CaptureArchive(part).HexPath<T>();

        IEncodedHexArchive UriBitsArchive(FolderPath root)
            => Archives.EncodedHexArchive(root);

        void WriteAsm(CapturedCode capture, StreamWriter dst)
        {
            var asm = Decoder.Decode(capture).Require();
            var formatted = Formatter.FormatFunction(asm);
            dst.Write(formatted);            
        }

        void WriteAsm(CapturedCode[] src, StreamWriter dst)
        {
            for(var i=0; i<src.Length; i++)
                WriteAsm(src[i], dst);
        }

        void WriteAsm(AsmFunction f, StreamWriter dst)
            => dst.WriteLine(Formatter.FormatFunction(f));
    }
}