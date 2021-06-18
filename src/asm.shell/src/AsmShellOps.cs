//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;

    using Windows;

    using static Root;
    using static core;

    using K = AsmCmdKind;

    unsafe class AsmShellOps : IDisposable
    {
        readonly NativeBuffer CodeBuffer;

        readonly Action<object> Receiver;

        readonly IWfRuntime Wf;

        public AsmShellOps(IWfRuntime wf, Action<object> receiver)
        {
            Wf = wf;
            CodeBuffer = Buffers.native(Pow2.T10);
            Receiver = receiver;
        }

        public void Dispose()
        {
            CodeBuffer.Dispose();
        }

        void Push(object content)
            => Receiver(content);

        uint LoadBuffer(uint offset, ReadOnlySpan<byte> src)
        {
            var i0 = offset;
            var dst = CodeBuffer.Allocated;
            var j=offset;
            for(var i=0; i<src.Length; i++)
                seek(dst, offset++) = skip(src,i);
            return offset - i0;
        }

        static ReadOnlySpan<byte> min64u_64u_64u
            => new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x3b,0xca,0x72,0x04,0x48,0x8b,0xc2,0xc3,0x48,0x8b,0xc1,0xc3};

        [CmdImpl(K.Exec)]
        void Exec(object[] args)
        {
            LoadBuffer(0,min64u_64u_64u);
            var pCode = CodeBuffer.Address.Pointer<byte>();
            var name = "min64u";
            var f = BinaryOpDynamics.binop<ulong>(name, pCode);
            var a = 4ul;
            var b = 12ul;
            var c = f(a,b);
            Push(string.Format("{0}({1},{2})={3}", name, a, b, c));
        }

        [CmdImpl(K.Demos)]
        void Demos(object[] args)
        {
            DynamicDemos.runA(result => Push(result));
            DynamicDemos.runB(result => Push(result));
            DynamicDemos.runC(result => Push(result));
        }

        [CmdImpl(K.Processor)]
        void Processor(object[] args)
        {
            Push(string.Format("{0}() => {1}", K.Processor, Kernel32.GetCurrentProcessorNumber()));
        }

        [CmdImpl(K.ProcessSdm)]
        void ProcessSdm(object[] args)
        {
            Wf.IntelSdmProcessor().Run();
        }

        [CmdImpl(K.Registers)]
        unsafe void Registers(object[] args)
        {
            var id = Kernel32.GetCurrentThreadId();
            using var thread = OpenThread(id);
            Push(string.Format("Thread: {0}", thread.Handle.ToAddress()));
            var context = new ThreadContext();
            context.ContextFlags = ContextFlags.CONTEXT_INTEGER;
            if(Kernel32.GetThreadContext(thread, &context))
            {
                Push(string.Format("{0}: {1}", "RAX", context.Rax));
            }
            else
            {
                Push("Command failed");
            }
        }

        static OpenHandle OpenThread(uint threadId)
            => Kernel32.OpenThread(ThreadAccess.THREAD_ALL_ACCESS,true, threadId);
    }
}