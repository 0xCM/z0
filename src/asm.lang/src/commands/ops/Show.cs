//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Windows;

    using static Root;
    using static core;
    using static IntelSdm;

    partial class AsmCmdService
    {
        Outcome ShowEffective(CmdArgs args)
        {
            //var e1 = asm.effective(w8,)
            return true;
        }


        [CmdOp(".core")]
        Outcome ShowCurrentCore(CmdArgs args)
        {
            Wf.Row(string.Format("Cpu:{0}",Kernel32.GetCurrentProcessorNumber()));
            return true;
        }

        [CmdOp(".captured")]
        Outcome ShowCaptured(CmdArgs args)
        {
            var packs = Wf.ApiPacks();
            var catalog = Wf.ApiCatalogs();
            var available = packs.List();
            iter(available, a => Wf.Row(a.Root));
            var current = available.Last;
            var archive = packs.Archive(current.Root);
            var entries = catalog.LoadApiCatalog(archive.ContextRoot());
            var formatter = Tables.formatter<ApiCatalogEntry>();
            iter(entries, entry => Wf.Row(formatter.Format(entry)));
            return true;
        }

        [CmdOp(".respack-members")]
        Outcome ShowResPackMembers(CmdArgs args)
        {
            var provider = Wf.ApiResProvider();
            var accessors = provider.ResPackAccessors();
            var count = accessors.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var access = ref skip(accessors,i);
                var row = string.Format("{0,-12} | {1, -24} | {2}", access.Host.Part, access.Host.HostName, access.Member.DisplaySig());
                Wf.Row(row);
            }
            return true;
        }

        [CmdOp(".env")]
        Outcome ShowEnv(CmdArgs args)
        {
            var vars = SystemEnv.vars();
            iter(vars, v => Wf.Row(v));
            return true;
        }

        [CmdOp(".thread")]
        Outcome ShowThread(CmdArgs args)
        {
            var id = Kernel32.GetCurrentThreadId();
            Wf.Row(string.Format("ThreadId:{0}", id));
            return true;
        }
    }
}