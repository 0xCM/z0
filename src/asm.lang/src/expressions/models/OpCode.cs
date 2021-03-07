//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;

    partial struct AsmExpr
    {
        public sealed class OpCodeLookup : Dictionary<string,OpCode>
        {
            public static OpCodeLookup create()
                => new OpCodeLookup();

            [MethodImpl(Inline)]
            public void AddIfMissing(OpCode src)
                => TryAdd(src.Format(), src);
        }

        public readonly struct OpCode : IComparable<OpCode>
        {
            readonly TextBlock Data;

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

            public int CompareTo(OpCode src)
                => Data.CompareTo(src.Data);

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