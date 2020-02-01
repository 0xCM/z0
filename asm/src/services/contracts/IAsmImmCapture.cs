//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using Z0.AsmSpecs;

    using static zfunc;

    public interface IAsmImmCapture
    {
        AsmFunction Capture(byte imm8);

        IEnumerable<AsmFunction> Capture(params byte[] immediates)
            => immediates.Select(Capture);
        
    }

    public interface IAsmImmCapture<T> : IAsmImmCapture
        where T : unmanaged
    {

    }

    public interface IAsmImmUnaryCapture : IAsmImmCapture
    {
        AsmFunction CaptureUnary(byte imm8);

        IEnumerable<AsmFunction> CaptureUnary(params byte[] immediates)
            => immediates.Select(CaptureUnary);
        
        AsmFunction IAsmImmCapture.Capture(byte imm8)
            => CaptureUnary(imm8);

        IEnumerable<AsmFunction> IAsmImmCapture.Capture(params byte[] imm)
            => CaptureUnary(imm);

    }    

    public interface IAsmImmBinaryCapture : IAsmImmCapture
    {
        AsmFunction CaptureBinary(byte imm8);

        IEnumerable<AsmFunction> CaptureBinary(params byte[] immediates)
            => immediates.Select(CaptureBinary);

        AsmFunction IAsmImmCapture.Capture(byte imm8)
            => CaptureBinary(imm8);

        IEnumerable<AsmFunction> IAsmImmCapture.Capture(params byte[] imm)
            => CaptureBinary(imm);

    }    



    public interface IAsmImmUnaryCapture<T> : IAsmImmCapture<T>, IAsmImmUnaryCapture
        where T : unmanaged        
    {
    }

    public interface IAsmImmBinaryCapture<T> : IAsmImmCapture<T>,  IAsmImmBinaryCapture
        where T : unmanaged        
    {
    }
}