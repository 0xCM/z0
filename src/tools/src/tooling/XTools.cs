//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Tools;


   [ApiHost]
   public static partial class XTools
   {
       [Op]
       public static Nasm Nasm(this IWfRuntime wf)
            => Tools.Nasm.create(wf);

       [Op]
       public static XedTool XedTool(this IWfRuntime wf)
            => Tools.XedTool.create(wf);

        public static DumpBin DumpBin(this IWfRuntime wf)
            => Tools.DumpBin.create(wf);

       [Op]
       public static ScriptRunner ScriptRunner(this IWfRuntime wf)
            => Z0.ScriptRunner.create(wf.Db());

       [Op]
       public static ScriptRunner ScriptRunner(this IEnvPaths paths)
            => Z0.ScriptRunner.create(paths);

        [Op]
        public static CultProcessor CultProcessor(this IWfRuntime wf)
            => Tools.CultProcessor.create(wf);
   }
}