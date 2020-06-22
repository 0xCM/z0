//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.IO;

    public interface IAsmTester : 
        IService<IAsmContext>, 
        IBufferedChecker, 
        ITestDynamic, 
        ICheckVectors, 
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

        TCaptureArchive CaptureArchive(PartId part)
            => Archives.CaptureArchive(
                (Env.Current.LogDir + FolderName.Define("apps")) + FolderName.Define(part.Format()), 
                FolderName.Define("capture"));

        TCaptureArchive CaptureArchive(FolderPath root)
            => Archives.CaptureArchive(root, null, null);

        FilePath AsmFilePath<T>(PartId part) 
            => CaptureArchive(part).AsmPath<T>();

        FilePath HexFilePath<T>(PartId part) 
            => CaptureArchive(part).HexPath<T>();

        IEncodedHexArchive UriBitsArchive(FolderPath root)
            => Archives.HexArchive(root);

        void WriteAsm(CapturedCode capture, StreamWriter dst)
        {
            var asm = Decoder.Decode(capture).Require();
            var formatted = Formatter.FormatFunction(asm);
            dst.WriteLine(formatted);            
        }

        void WriteAsm(AsmFunction f, StreamWriter dst)
            => dst.WriteLine(Formatter.FormatFunction(f));
    }
}