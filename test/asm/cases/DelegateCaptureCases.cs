//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    class CaptureCases
    {
        public static Func<Vector256<uint>, Vector256<uint>> shuffler(byte imm)
            => v => Avx2.Shuffle(v, imm);

        public static Func<Vector256<uint>, Vector256<uint>> shifter(byte imm)
            => v => Avx2.ShiftLeftLogical(v,imm);

        public static Func<Vector256<uint>,Vector256<uint>,Vector256<uint>> And256
            => Avx2.And;

        public static IEnumerable<MethodInfo> vand =>
            typeof(gcpu).DeclaredStaticMethods()
                        .OpenGeneric()
                        .WithName("vand")
                        .Select(m => m.GetGenericMethodDefinition().MakeGenericMethod(typeof(uint)))
                        .ToArray();
    }
}