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

    public readonly partial struct CellFunctions
    {
        public interface ISignature
        {
            TypeWidth ResultWidth {get;}
        }

        public interface ISignature<H> : ISignature
            where H : unmanaged, ISignature<H>
        {
            ReadOnlySpan<TypeWidth> ArgWidths {get;}
        }

        public interface ISignature<H,R> : ISignature
            where H : unmanaged, ISignature<H,R>
            where R : unmanaged, IDataCell
        {
        }

        public interface ISignature<H,A,R> : ISignature
            where H : unmanaged, ISignature<H,A,R>
            where R : unmanaged, IDataCell
            where A : unmanaged, IDataCell
        {
            TypeWidth Width(N0 n);
        }

        public interface ISignature<H,A,B,R> : ISignature
            where H : unmanaged, ISignature<H,A,B,R>
            where R : unmanaged, IDataCell
            where A : unmanaged, IDataCell
            where B : unmanaged, IDataCell
        {
            TypeWidth Width(N0 n);

            TypeWidth Width(N1 n);
        }

        public interface ISignature<H,A,B,C,R> : ISignature
            where H : unmanaged, ISignature<H,A,B,C,R>
            where R : unmanaged, IDataCell
            where A : unmanaged, IDataCell
            where B : unmanaged, IDataCell
            where C : unmanaged, IDataCell
        {
            TypeWidth Width(N0 n);

            TypeWidth Width(N1 n);

            TypeWidth Width(N2 n);
        }
    }
}