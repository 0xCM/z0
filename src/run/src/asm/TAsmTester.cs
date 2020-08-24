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
        ICaptureChecker
    {
        IAsmDecoder Decoder
            => Context.RoutineDecoder;

        IAsmFormatter Formatter
            => Context.Formatter;

        IUriHexQuery UriBitQuery
            => Z0.UriHexQuery.Service;

        IArchiveServices Archives
            => Z0.Archives.Services;

        IPolyrand IPolyrandProvider.Random
            => Context.Random;

        ICaptureCore ICaptureServiceProxy.CaptureService
            => Context.CaptureCore;

        IPartCaptureArchive CaptureArchive(PartId part)
            => Archives.CaptureArchive(
                (EnvVars.Common.LogRoot + FolderName.Define("apps")) + FolderName.Define(part.Format()),
                FolderName.Define("capture"));

        IPartCaptureArchive CaptureArchive(FolderPath root)
            => Archives.CaptureArchive(root, null, null);

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

        void WriteAsm(AsmRoutine f, StreamWriter dst)
            => dst.WriteLine(Formatter.FormatFunction(f));
    }
}