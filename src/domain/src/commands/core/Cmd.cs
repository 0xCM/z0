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

        internal const string CmdIdNotFound = "Command identifier not found";

        internal const char DefaultSpecifier = Chars.Colon;

        const NumericKind Closure = UnsignedInts;

        [Op, Closures(UInt64k)]
        public static CmdSpec untype<T>(in T spec)
            where T : struct
        {
            var t = typeof(T);
            var fields = ClrQuerySvc.fields(t);
            var count = fields.Count;
            var reflected = alloc<FieldValue>(count);
            ClrQuerySvc.values(spec, fields, reflected);
            var buffer = alloc<CmdOption>(count);
            var target = span(buffer);
            var source = @readonly(reflected);
            for(var i=0u; i<count; i++)
            {
                ref var option = ref seek(target,i);
                ref readonly var fv = ref skip(source,i);
                option.Name = fv.Field.Name;
                option.Value = fv.Value?.ToString() ?? EmptyString;
            }
            return new CmdSpec(Cmd.id(t), buffer);
        }

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
        public static int execute(IWfShell wf, CmdSpec spec)
        {
            return 0;
        }

        public static CmdJob<T> job<T>(string name, T spec)
            where T : struct, ITextual
                => new CmdJob<T>(name, spec);
    }
}