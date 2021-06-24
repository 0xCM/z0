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


        Outcome DispatchAsmCmd(string name, CmdArgs args)
        {
            var cmd = Wf.AsmCmd();
            return cmd.Dispatch(name,args);
        }

        void Dispatch(CmdSpec<K> spec)
        {
            var id = spec.Id;
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
                    var args = spec.Args.Storage.Cast<object>();
                    method.Invoke(ShellOps, new object[]{args});
                }
                catch(Exception e)
                {
                    term.error(e);
                }
            }
        }

        CmdSpec<K> Pull()
        {
            var input = term.prompt("cmd> ");
            var i = input.IndexOf(Chars.Space);
            var args = StringIndex.Empty;
            var name = input;
            if(i != NotFound)
            {
                name = TextTools.left(input,i);
                var right = TextTools.right(input,i);
                if(nonempty(right))
                    args = right.Split(Chars.Space);
            }

            if(CommandMap.TryGetValue(name, out K kind))
            {
                return Cmd.spec(kind, args);
            }
            else
            {
                Push(string.Format("The command '{0}' is not recognized", name));
                return CmdSpec<K>.Empty;
            }
        }

        protected override void Run()
        {
            var input = Pull();
            while(input.Id != K.Exit)
            {
                if(input.Id != 0)
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