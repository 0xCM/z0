//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct AsmQuery : TSemanticQuery
    {
        [MethodImpl(Inline)]
        public static bool signedImm(OpKind src)
            => asm.testimmSigned(src);

        [MethodImpl(Inline)]
        public static bool directImm(OpKind src)
            => asm.testimmDirect(src);

        [MethodImpl(Inline)]
        public static bool specialImm(OpKind src)
            => asm.testimmSpecial(src);

        [MethodImpl(Inline)]
        public static bool isImm(OpKind src)
            => asm.testimm(src);

        [MethodImpl(Inline)]
        public NumericWidth ImmWidth(OpKind src)
            => asm.immwidth(src);
        
        [MethodImpl(Inline)]
        public ulong ExtractImm(Instruction src, int index) 
            => asm.immval(src,index);
		
        [MethodImpl(Inline)]
        public bool IsSignedImm(OpKind src)
            => signedImm(src);

        [MethodImpl(Inline)]
        public bool IsDirectImm(OpKind src)
            => directImm(src);
            
        [MethodImpl(Inline)]
        public bool IsSpecialImm(OpKind src)
            => specialImm(src);

        [MethodImpl(Inline)]
        public bool IsImm(OpKind src)
            => asm.testimm(src);

        [MethodImpl(Inline)]
        public AsmImmInfo ImmInfo(Instruction src, int index) 
            => asm.imminfo(src,index);
    }
}