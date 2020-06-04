//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using M = OpCodeModel;

    using E = OpCodes.Identifiers;
    using C = OpCodes.Expressions;
    using I = OpCodes.Instructions;
    using D = OpCodes.Descriptions;

    public class OpCodeModels
    {
        public static M JaRel8 => (E.JaRel8, C.JaRel8, I.JaRel8, D.JaRel8);

        public static M JaRel16 => (E.JaRel16, C.JaRel16, I.JaRel16, D.JaRel16);

        public static M JaRel32 => (E.JaRel32, C.JaRel32, I.JaRel32, D.JaRel32);

        public static M JaeRel8 => (E.JaeRel8, C.JaeRel8, I.JaeRel8, D.JaeRel8);

        public static M JaeRel16 => (E.JaeRel16, C.JaeRel16, I.JaeRel16, D.JaeRel16);

        public static M JaeRel32 => (E.JaeRel32, C.JaeRel32, I.JaeRel32, D.JaeRel32);
    }
}