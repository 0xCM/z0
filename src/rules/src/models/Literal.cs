//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        /// <summary>
        /// Defines a literal value which, by definition, is a named constant
        /// </summary>
        public readonly struct Literal
        {
            public string Name {get;}

            public Constant Value {get;}

            [MethodImpl(Inline)]
            public Literal(string id, Constant value)
            {
                Name = id;
                Value = value;
            }
        }
    }
}