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

        ApiCodeQuery UriBitQuery
            => Z0.ApiCodeQuery.Service;

        IPolyrand IPolyrandProvider.Random
            => Context.Random;

        ICaptureCore ICaptureServiceProxy.CaptureService
            => Context.CaptureCore;

        IPartCapturePaths CaptureArchive(FolderPath root)
            => Archives.capture(root);

        void WriteAsm(ApiCaptureBlock capture, StreamWriter dst)
        {
            var asm = Decoder.Decode(capture).Require();
            var formatted = Formatter.FormatFunction(asm);
            dst.Write(formatted);
        }

        void WriteAsm(ApiCaptureBlock[] src, StreamWriter dst)
        {
            for(var i=0; i<src.Length; i++)
                WriteAsm(src[i], dst);
        }

        void WriteAsm(ReadOnlySpan<ApiCaptureBlock> src, StreamWriter dst)
        {
            for(var i=0; i<src.Length; i++)
                WriteAsm(src[i], dst);
        }

        void WriteAsm(AsmRoutine f, StreamWriter dst)
            => dst.WriteLine(Formatter.FormatFunction(f));
    }
}