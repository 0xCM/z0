//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;

    using static Root;
    using static core;

    using K = AsmCmdKind;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public unsafe sealed class AsmShell : WfApp<AsmShell>
    {
        CmdIndex<AsmCmdKind> Commands;

        Dictionary<string,AsmCmdKind> CommandMap;

        CmdImplMap<AsmCmdKind> ImplMap;

        AsmShellOps ShellOps;

        void MapCommands()
        {
            Commands = Cmd.index<AsmCmdKind>();
            for(var i=0; i<Commands.Count; i++)
            {
                var id = (AsmCmdKind)i;
                ref readonly var cmd = ref Commands[id];
                CommandMap[cmd.Name] = id;
            }
        }

        protected override void Initialized()
        {
            MapCommands();
            ShellOps = MapOps();
            ImplMap = MapImpl();
        }

        AsmShellOps MapOps()
            => new AsmShellOps(Wf, Push);

        CmdImplMap<AsmCmdKind> MapImpl()
            => Cmd.implmap<AsmCmdKind>(typeof(AsmShellOps));

        public AsmShell()
        {
            ImplMap = new();
            CommandMap = new();
        }

        ref readonly CmdInfo<AsmCmdKind> LookupCmd(K id)
            => ref Commands[id];

        MethodInfo LookupMethod(K id)
            => ImplMap[id];

        void Help(in CmdInfo<AsmCmdKind> cmd)
        {
            iter(Commands.View, c => term.cyan(string.Format("{0,-14} - {1}", c.Name, c.Description)));
        }

        void Push(object content)
        {
            term.cyan(string.Format(">>   {0}", content));
        }

        void Dispatch(K id)
        {
            ref readonly var cmd = ref LookupCmd(id);
            if(id == K.Help)
            {
                Help(cmd);
            }
            else
            {
                var method = LookupMethod(id);
                try
                {
                    method.Invoke(ShellOps, new object[]{new object[]{}});
                }
                catch(Exception e)
                {
                    term.error(e);
                }
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

        protected override void Disposing()
        {
            ShellOps.Dispose();
        }

        public static void Main(params string[] args)
        {
            using var wf = WfAppLoader.load();
            using var shell = create(wf);
            shell.Run();
        }
    }
}