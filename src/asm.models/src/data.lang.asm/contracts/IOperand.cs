//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct AsmLang
    {
        public interface IOperand
        {
            AsmOperandKind Kind {get;}

        }

       public interface IOperand<T> : IOperand
            where T : unmanaged
       {
            T Value {get;}

       }

       public interface IOperand<H,T> : IOperand<T>
            where H : struct, IOperand<H,T>
            where T : unmanaged
        {

        }
    }
}