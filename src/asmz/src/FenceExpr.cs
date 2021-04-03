//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Rules;

    public readonly struct FenceExprCases
    {
        public const string CaseA = @"((INST ""ADD"" (OP :OP #x0)
          (ARG :OP1 '(E B) :OP2 '(G B))
          '(X86-ADD/ADC/SUB/SBB/OR/AND/XOR/CMP/TEST-E-G (OPERATION . #x0))
          '((:UD (UD-LOCK-USED-DEST-NOT-MEMORY-OP))))";
    }

    public readonly struct FenceExpr
    {
        public Fence<char> Fence {get;}

        public string Content {get;}

        [MethodImpl(Inline)]
        public FenceExpr(Fence<char> fence, string src)
        {
            Fence = fence;
            Content = src;
        }

        [MethodImpl(Inline)]
        public static implicit operator FenceExpr((Fence<char> fence, string content) src)
            => new FenceExpr(src.fence, src.content);

        [MethodImpl(Inline)]
        public static implicit operator FenceExpr((char left, char right, string content) src)
            => new FenceExpr((src.left,src.right), src.content);
    }
}