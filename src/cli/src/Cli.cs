//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using Msil;
    using System.Reflection.Metadata;

    [ApiHost(ApiNames.Cil, true)]
    public readonly partial struct Cil
    {
        public static void visualize(FS.FilePath src, FS.FilePath dst)
            => Mdv.run(src.Name,dst.Name);

        [Op]
        public static string format(CliSig src)
            => DefaultCilFormatProvider.Instance.SigByteArrayToString(src);

        readonly Index<OpCodeInfo> Data;

        [Op]
        public static Cil init()
        {
            var buffer = sys.alloc<OpCodeInfo>(300);
            ref var dst = ref first(span(buffer));
            OpCodes.load(ref dst);
            return new Cil(buffer);
        }

        [MethodImpl(Inline)]
        Cil(OpCodeInfo[] src)
            => Data = src;
    }

    [ApiHost]
    public readonly partial struct Cli
    {

    }

    [ApiHost]
    public static partial class XCmd
    {

    }

    public static partial class XSvc
    {
        [ServiceFactory]
        public static IPdbSymbolStore PdbSymbolStore(this IWfShell wf)
            => PdbSymbolStoreSvc.create(wf);
    }
}