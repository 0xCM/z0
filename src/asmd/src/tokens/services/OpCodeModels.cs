//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using M = OpCodeModel;

    using E = OpCodeIdentity;
    using C = OpCodeExpressions;
    using I = InstructionExpressions;

    using static Konst;

    [ApiHost("opcodes.models")]
    public readonly struct OpCodeModels
    {
        public static OpCodeModels Service => default;

        [MethodImpl(Inline), Op]
        public M JaRel8() 
            => define(E.JaRel8, C.JaRel8, I.JaRel8);

        [MethodImpl(Inline), Op]
        public M JaRel16() 
            => define(E.JaRel16, C.JaRel16, I.JaRel16);

        [MethodImpl(Inline), Op]
        public M JaRel32() 
            => define(E.JaRel32, C.JaRel32, I.JaRel32);

        [MethodImpl(Inline), Op]
        public M JaeRel8() 
            => define(E.JaeRel8, C.JaeRel8, I.JaeRel8);

        [MethodImpl(Inline), Op]
        public M JaeRel16() 
            => define(E.JaeRel16, C.JaeRel16, I.JaeRel16);

        [MethodImpl(Inline), Op]
        public M JaeRel32() 
            => define(E.JaeRel32, C.JaeRel32, I.JaeRel32);

        [MethodImpl(Inline), Op]
        static OpCodeModel define(string id, string cx, string ix)
            => new OpCodeModel(id,cx,ix);
    }
}