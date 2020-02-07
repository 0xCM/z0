//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;        

    using static zfunc;

    public static class CaptureServices
    {
        public const int DefaultBufferLen = 1024*8;
        
        public static ICaptureOps Operations
        {
            [MethodImpl(Inline)]
            get => default(CaptureOps);
        }

        [MethodImpl(Inline)]
        public static ICaptureControl Control()
            => CaptureControl.Create();

        [MethodImpl(Inline)]
        public static ICaptureControl Control(ICaptureEventSink sink)
            => CaptureControl.Create(sink);

        [MethodImpl(Inline)]
        public static CaptureExchange Exchange(ICaptureControl control, Span<byte> target, Span<byte> state)
            => CaptureExchange.Define(control, target, state);

        [MethodImpl(Inline)]
        public static CaptureExchange Exchange(ICaptureControl control)
            => Exchange(control, new byte[CaptureServices.DefaultBufferLen], new byte[CaptureServices.DefaultBufferLen]);

        [MethodImpl(Inline)]
        public static CaptureExchange Exchange(Span<byte> target, Span<byte> state)
            => Exchange(Control(), target,state);

        [MethodImpl(Inline)]
        public static CaptureExchange Exchange()
            => Exchange(Control());

        [MethodImpl(Inline)]
        public static IAsmEmissionSink EmissionSink(Action<AsmEmissionGroup> receiver)
            => AmsEmissionSink.Create(receiver);

        /// <summary>
        /// Allocates a caller-disposed capture writer
        /// </summary>
        /// <param name="dst">The target path</param>
        /// <param name="header">Whether to emit a header when creating a new file or overwriting an existing file</param>
        /// <param name="append">Whether to append to or overwrite an existing file</param>
        public static ICaptureWriter Writer(FilePath dst, bool header = true, bool append = false)
            => CaptureWriter.Create(dst,header,append);
    }
}