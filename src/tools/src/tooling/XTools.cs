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
       public static Nasm nasm(this IWfShell wf)
            => Nasm.create(wf);
   }
}