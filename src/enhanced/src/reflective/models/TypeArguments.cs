//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TypeArguments
    {
        [MethodImpl(Inline)]
        public static TypeArguments Define(params TypeArgument[] args)
            => new TypeArguments(args);

        [MethodImpl(Inline)]
        internal TypeArguments(TypeArgument[] args)
        {
            Arguments = args;
        }

        public TypeArgument[] Arguments {get;}

        public TypeArgument this[int index] 
            => Arguments[index];
        
        public int Count 
            => Arguments.Length;
    }
}