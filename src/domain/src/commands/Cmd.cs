//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.Cmd, true)]
    public readonly partial struct Cmd
    {
        internal const byte MaxVarCount = 16;

        internal const string Anonymous = "anonymous";

        const NumericKind Closure = UnsignedInts;

        public static CmdVars vars(byte count)
            => new CmdVars(new CmdVar[count]);

        public static CmdVars vars()
            => new CmdVars(new CmdVar[MaxVarCount]);

        public static CmdVars<K> vars<K>()
            where K : unmanaged
                => new CmdVars<K>(new CmdVar<K>[MaxVarCount]);

        public static FS.FilePath enqueue<T>(CmdJob<T> job, IFileDb db)
            where T : struct, ITextual
        {
            var dst = db.JobQueue() + FS.file(job.Name.Format(), ArchiveFileKinds.Cmd);
            dst.Overwrite(job.Format());
            return dst;
        }

        [Op]
        public static int execute(IWfShell wf, CmdId id, params CmdOption[] options)
        {
            return 0;
        }

        [MethodImpl(Inline)]
        public static asci32 name<K,T>(in CmdOption<K,T> src)
            where K : unmanaged
                => src.Kind.ToString().ToLower();

        public static CmdJob<T> job<T>(string name, T spec)
            where T : struct, ITextual
                => new CmdJob<T>(name, spec);
    }
}