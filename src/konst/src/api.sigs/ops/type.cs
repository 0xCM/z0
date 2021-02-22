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

    partial struct ApiSigs
    {
        [MethodImpl(Inline), Op]
        public static TypeSig type(Name name, params ITypeParameter[] parameters)
            => new TypeSig(name, parameters);

        [MethodImpl(Inline), Op]
        public static OpenParameter open(ushort position, Name name)
            => new OpenParameter(position, name);

        [MethodImpl(Inline), Op]
        public static ClosedParameter close(OpenParameter src, TypeSig closure)
            => new ClosedParameter(src.Position, src.Name, closure);
    }
}