//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;

    partial struct Evaluate
    {
        [MethodImpl(Inline), Op]
        public static IEvalControl control(IAppContext context, FolderPath root, uint bufferSize)
            => new EvalControl(context, context.Random, root, bufferSize);
    }
}