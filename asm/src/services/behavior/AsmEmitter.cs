//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;

    public static class AsmEmitter
    {
        public static void Emit(FastDirectInfo op, AsmArchive target)
            => target.Save(op.Method.FastOp().NativeData.Code);                

        public static void Emit(FastGenericInfo op, AsmArchive target)
        {
            foreach(var k in op.Kinds)
            {
                var method = op.Method.MakeGenericMethod(k.ToPrimalType());
                target.Save(method.FastOp().NativeData.Code);
            }
        }

    }

}