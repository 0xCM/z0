//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct FormalModels
    {
        partial struct Circuits
        {
            public readonly struct GateName
            {
                readonly text7 Data;

                [MethodImpl(Inline)]
                public GateName(string name)
                {
                    Data = name;
                }

                [MethodImpl(Inline)]
                public GateName(char symbol)
                {
                    Data = symbol;
                }

                public string Format()
                    => Data.Format();

                public override string ToString()
                    => Format();

                [MethodImpl(Inline)]
                public static implicit operator GateName(string name)
                    => new GateName(name);

                [MethodImpl(Inline)]
                public static implicit operator GateName(char symbol)
                    => new GateName(symbol);
            }
        }
    }
}