//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct CellFunctions
    {
        [ApiHost(ApiNames.CellFxSig)]
        public readonly struct Signatures
        {
            [MethodImpl(Inline), Op]
            public static Signature define(TypeWidth r)
                => new Signature(vparts(w128, z16, 0,0,0,0,0,0, (ushort)r));

            [MethodImpl(Inline), Op]
            public static Signature define(TypeWidth a, TypeWidth r)
                => new Signature(vparts(w128, (ushort)a, 0,0,0,0,0,0, (ushort)r));

            [MethodImpl(Inline), Op]
            public static Signature define(TypeWidth a, TypeWidth b, TypeWidth r)
                => new Signature(vparts(w128, (ushort)a, (ushort)b,0,0,0,0,0, (ushort)r));

            [MethodImpl(Inline), Op]
            public static Signature define(TypeWidth a, TypeWidth b, TypeWidth c, TypeWidth r)
                => new Signature(vparts(w128, (ushort)a, (ushort)b,(ushort)c,0,0,0,0, (ushort)r));

            public static Fx<A> define<A>(A a = default)
                where A : unmanaged, IDataCell
                    => default;

            public static Fx<A,B> define<A,B>(A a = default, B b = default)
                where A : unmanaged, IDataCell
                where B : unmanaged, IDataCell
                    => default;

            public static Fx<A,B,C> define<A,B,C>(A a = default, B b = default, C c = default)
                where A : unmanaged, IDataCell
                where B : unmanaged, IDataCell
                where C : unmanaged, IDataCell
                    => default;

            public static Fx<A,B,C,D> define<A,B,C,D>(A a = default, B b = default, C c = default, D d = default)
                where A : unmanaged, IDataCell
                where B : unmanaged, IDataCell
                where C : unmanaged, IDataCell
                where D : unmanaged, IDataCell
                    => default;
        }
    }
}