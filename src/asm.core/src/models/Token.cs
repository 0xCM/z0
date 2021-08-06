//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Token
    {
        public uint Key {get;}

        public string Identifier {get;}

        public string Expression {get;}

        [MethodImpl(Inline)]
        public Token(uint key, string id, string expression)
        {
            Key = key;
            Identifier = id;
            Expression = expression;
        }

        public string Format()
            => string.Format("{0,-2} => {1} => '{2}'", Key, Identifier, Expression);

        public override string ToString()
            => Format();
    }
}