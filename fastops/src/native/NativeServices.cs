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

    public static class NativeServices
    {
        public const int DefaultBufferLen = 1024*8;
        
        public static INativeExecBuffer ExecBuffer(int? size = null)
            => NativeExecBuffer.Create(size);

        /// <summary>
        /// Intantiates the member capture service that jits and collects native member data
        /// </summary>
        [MethodImpl(Inline)]
        public static IMemberCapture MemberCapture()
            => default(MemberCapture);

        [MethodImpl(Inline)]
        public static ICaptureControl CaptureControl()
            => Z0.CaptureControl.Create();

        [MethodImpl(Inline)]
        public static ICaptureControl CaptureControl(IPointSink<CaptureState> sink)
            => Z0.CaptureControl.Create(sink.ToCaptureSink());

        [MethodImpl(Inline)]
        public static ICaptureControl CaptureControl(PointReceiver<CaptureState> receiver)
            => CaptureControl(receiver.ToPointSink());

        [MethodImpl(Inline)]
        public static CaptureExchange CaptureExchange(ICaptureControl control, Span<byte> target, Span<byte> state)
            => Z0.CaptureExchange.Define(control, target, state);

        [MethodImpl(Inline)]
        public static CaptureExchange CaptureExchange(ICaptureControl control)
            => CaptureExchange(control, new byte[NativeServices.DefaultBufferLen], new byte[NativeServices.DefaultBufferLen]);

        /// <summary>
        /// Allocates a caller-disposed native text writer
        /// </summary>
        /// <param name="dst">The target path</param>
        /// <param name="header">Whether to emit a header when creating a new file or overwriting an existing file</param>
        /// <param name="append">Whether to append to or overwrite an existing file</param>
        public static INativeWriter Writer(FilePath dst, bool header = true, bool append = false)
        {
            dst.FolderPath.CreateIfMissing();            
            var exists = dst.Exists();
            var writer = NativeWriter.Create(dst,append);            
            if(!exists || !append && header)
                writer.WriteHeader();
            return writer;
        }

    }
}