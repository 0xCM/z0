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
        ICheckVectors,
        ICaptureServiceProxy
    {
        IAsmDecoder Decoder
            => Context.RoutineDecoder;

        IAsmFormatter Formatter
            => Context.Formatter;

        ApiHexQuery UriBitQuery
            => Z0.ApiHexQuery.Service;

        IPolyrand IPolyrandProvider.Random
            => Context.Random;

        ICaptureCore ICaptureServiceProxy.CaptureService
            => Context.CaptureCore;


        IPartCapturePaths CaptureArchive(FolderPath root)
            => Z0.Archives.capture(root);

        void WriteAsm(X86ApiCapture capture, StreamWriter dst)
        {
            var asm = Decoder.Decode(capture).Require();
            var formatted = Formatter.FormatFunction(asm);
            dst.Write(formatted);
        }

        void WriteAsm(X86ApiCapture[] src, StreamWriter dst)
        {
            for(var i=0; i<src.Length; i++)
                WriteAsm(src[i], dst);
        }

        void WriteAsm(AsmRoutine f, StreamWriter dst)
            => dst.WriteLine(Formatter.FormatFunction(f));
    }
}