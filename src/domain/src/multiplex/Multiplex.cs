//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;
    using api = ClrArtifacts;

    [Free,ApiHost]
    public partial class Multiplex : IMultiplex
    {
        readonly WfHost Host;

        public IBuildArchive BuildArchive {get;}

        [MethodImpl(Inline), Op]
        public static MultiplexSettings configure(FS.FolderPath root)
        {
            var settings = new MultiplexSettings();
            settings.DbRoot = root;
            settings.BuildRoot = EnvVars.Common.BuildPubRoot;
            return settings;
        }

        [Op]
        public static Multiplex create(IWfShell wf, MultiplexSettings? settings = null)
        {
            var config = settings ?? configure(EnvVars.Common.DbRoot);
            var mpx = new Multiplex(wf, config);
            return mpx;
        }

        Multiplex(IWfShell wf, MultiplexSettings settings)
        {
            Host = WfSelfHost.create(typeof(Multiplex));
            BuildArchive = Z0.BuildArchive.create(wf, settings.BuildRoot);
        }

        // public IModuleArchive Modules
        //     => BuildArchive.Modules;


        [MethodImpl(Inline)]
        static void Print<T>(IWfShell wf, ReadOnlySpan<T> src)
            where T : ITextual
        {
            var count = src.Length;
            if(count != 0)
            {
                ref readonly var lead = ref first(src);
                for(var i=0u; i<count; i++)
                {
                    ref readonly var current = ref skip(lead, i);
                    wf.Row(current);
                }
            }
        }

        static void Traverse(IWfShell wf, ClrArtifactSet<ClrArtifacts.FieldView> src)
        {
            var count = src.Length;
            if(count == 0)
                return;

            var printer = new ClrArtifactPrinter(wf);
            ref readonly var lead = ref src.First;
            for(var i=0; i<count; i++)
            {
                ref readonly var current = ref skip(lead,i);
                printer.Print(current);
            }
        }

        public void Traverse(IWfShell wf, Assembly src)
        {
            var printer = new ClrArtifactPrinter(wf);
            var models = api.sTypes(src);
            var count = models.Length;
            ref readonly var lead = ref models.First;
            for(var i=0; i<count; i++)
            {
                ref readonly var current = ref skip(lead,i);
                printer.Print(current);

                Traverse(wf,api.vFields(current));
            }
        }
    }
}