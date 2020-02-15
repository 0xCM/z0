//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;
    using System.Collections;

    public class TypeArguments : IReadOnlyList<TypeArgument>
    {
        public static TypeArguments Define(params TypeArgument[] args)
            => new TypeArguments(args);

        TypeArguments(TypeArgument[] args)
        {
            Arguments = args;
        }

        TypeArgument[] Arguments {get;}

        public TypeArgument this[int index] 
            => Arguments[index];
        public int Count 
            => Arguments.Length;

        public IEnumerator<TypeArgument> GetEnumerator()
            => ((IReadOnlyList<TypeArgument>)Arguments).GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}