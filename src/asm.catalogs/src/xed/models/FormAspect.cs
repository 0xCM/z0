//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct XedModels
    {
        public readonly struct FormAspect : IDataTypeComparable<FormAspect>
        {
            public string Value {get;}

            [MethodImpl(Inline)]
            public FormAspect(string src)
                => Value = src;

            public bool Equals(FormAspect src)
                => Value.Equals(src.Value);

            [MethodImpl(Inline)]
            public int CompareTo(FormAspect src)
                => Value.CompareTo(src.Value);

            [MethodImpl(Inline)]
            public string Format()
                => Value;

            public override string ToString()
                => Format();

            public override int GetHashCode()
                => (int)alg.hash.marvin(Value);

            public override bool Equals(object src)
                => src is FormAspect c && Equals(c);

            [MethodImpl(Inline)]
            public static implicit operator FormAspect(string src)
                => new FormAspect(src);
        }
    }
}