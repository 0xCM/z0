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


    using K = AsmShellCmdKind;

    public unsafe sealed class AsmShell : WfApp<AsmShell>
    {
        Index<AsmShellCmdKind,AsmShellCmd> Commands;

        Dictionary<string,AsmShellCmdKind> CommandMap;

        NativeBuffer CodeBuffer;

        public static ReadOnlySpan<byte> min64u_64u_64u
            => new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x3b,0xca,0x72,0x04,0x48,0x8b,0xc2,0xc3,0x48,0x8b,0xc1,0xc3};

        void MapCommands()
        {
            CommandMap = new();
            var fields = @readonly(typeof(AsmShellCmdKind).Fields().Tagged<CmdSpecAttribute>());
            var count = fields.Length;
            Commands = alloc<AsmShellCmd>(byte.MaxValue);
            ref var buffer = ref Commands.First;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref var dst = ref seek(buffer, i);
                ref readonly var field = ref skip(fields,i);
                var id = (AsmShellCmdKind)field.GetRawConstantValue();
                dst.Id = id;
                var tag = field.Tag<CmdSpecAttribute>().Require();
                var name = tag.Name;
                dst.Name = StringAddress.resource(name);
                dst.Description = StringAddress.resource(tag.Description);
                CommandMap[name] = id;
                counter++;
            }

            for(var i=counter; i<Commands.Count; i++)
            {
                ref var dst = ref seek(buffer, i);
                dst.Id = K.None;
                dst.Name = StringAddress.resource(EmptyString);
                dst.Description = StringAddress.resource(EmptyString);
            }

        }

        public AsmShell()
        {
            CodeBuffer = Buffers.native(Pow2.T10);
            MapCommands();
        }

        ref readonly AsmShellCmd Lookup(K id)
            => ref Commands[id];

        void Push(object content)
        {
            term.cyan(string.Format(">>   {0}", content));
        }

        void Dispatch(K id)
        {
            ref readonly var cmd = ref Lookup(id);
            switch(id)
            {
                case K.Processor:
                    ShowProcessor(cmd);
                    break;
                case K.Help:
                    ShowHelp(cmd);
                    break;
                case K.Registers:
                    ShowRegisters(cmd);
                    break;
                case K.Demos:
                    RunDemos(cmd);
                    break;
                case K.Exec:
                    Exec(cmd);
                    break;
            }
        }

        K Pull()
        {
            var input = term.prompt("cmd> ");
            if(CommandMap.TryGetValue(input, out K kind))
            {
                return kind;
            }
            else
            {
                Push(string.Format("The command {0} is not recognized", input));
                return default;
            }
        }

        protected override void Run()
        {
            var input = Pull();
            while(input != K.Exit)
            {
                if(input != 0)
                    Dispatch(input);

                input = Pull();
            }
        }

        uint LoadBuffer(uint offset, ReadOnlySpan<byte> src)
        {
            var i0 = offset;
            var dst = CodeBuffer.Allocated;
            var j=offset;
            for(var i=0; i<src.Length; i++)
                seek(dst, offset++) = skip(src,i);
            return offset - i0;
        }

        void Exec(in AsmShellCmd cmd)
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

        void RunDemos(in AsmShellCmd cmd)
        {
            DynamicDemos.runA(result => Push(result));
            DynamicDemos.runB(result => Push(result));
            DynamicDemos.runC(result => Push(result));
        }

        void ShowProcessor(in AsmShellCmd cmd)
        {
            Push(string.Format("{0}() => {1}", cmd.Name, Kernel32.GetCurrentProcessorNumber()));
        }

        void ShowHelp(in AsmShellCmd cmd)
        {
            iter(Commands, c => term.cyan(string.Format("{0,-14} - {1}", c.Name, c.Description)));
        }

        public static OpenHandle OpenThread(uint threadId)
            => Kernel32.OpenThread(ThreadAccess.THREAD_ALL_ACCESS,true, threadId);

        unsafe void ShowRegisters(in AsmShellCmd cmd)
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

        protected override void Disposing()
        {
            CodeBuffer.Dispose();
        }

        public static void Main(params string[] args)
        {
            using var wf = WfAppLoader.load();
            using var shell = create(wf);
            shell.Run();
        }
    }
}