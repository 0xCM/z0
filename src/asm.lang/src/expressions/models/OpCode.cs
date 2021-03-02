//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmExpr
    {
        public readonly struct OpCode
        {
            readonly TextBlock<N32> Data;

            [MethodImpl(Inline)]
            public OpCode(string src)
                => Data = src;

            public string Content
            {
                [MethodImpl(Inline)]
                get => Data.Text;
            }

            public int Length
            {
                [MethodImpl(Inline)]
                get => Data.Length;
            }

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => Data.IsEmpty;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => Data.IsNonEmpty;
            }

            public override int GetHashCode()
                => Data.GetHashCode();

            [MethodImpl(Inline)]
            public string Format()
                => Data.Format();

            public override string ToString()
                => Format();

            public override bool Equals(object src)
                => src is OpCode x && Equals(x);

            [MethodImpl(Inline)]
            public bool Equals(OpCode src)
                => Data.Equals(src.Data);

            [MethodImpl(Inline)]
            public static bool operator ==(OpCode a, OpCode b)
                => a.Equals(b);

            [MethodImpl(Inline)]
            public static bool operator !=(OpCode a, OpCode b)
                => !a.Equals(b);

            public static OpCode Empty
                => new OpCode(EmptyString);
        }
    }
}