//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Tooling;

   [ApiHost]
   public static partial class XTools
   {
       [Op]
       public static Nasm nasm(this IWfRuntime wf)
            => Nasm.create(wf);

       [Op]
       public static ScriptRunner ScriptRunner(this IWfRuntime wf)
            => Z0.ScriptRunner.create(wf.Db());

       [Op]
       public static ScriptRunner ScriptRunner(this IEnvPaths paths)
            => Z0.ScriptRunner.create(paths);
   }
}