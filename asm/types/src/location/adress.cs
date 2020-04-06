//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    
    using static AsmSpecs;
    using static AsmTypes;

    partial class AsmSpecs
    {
        public interface address<W> : location
            where W : unmanaged, IDataWidth
        {
            scalar<W> Scalar {get;}        
        }
        
        public interface address<F,W> : address<W>
            where F : struct, address<F,W>        
            where W : unmanaged, IDataWidth
        {

        }

        public interface address<F,S,W> : address<F,W>
            where F : struct, address<F,S,W>        
            where W : unmanaged, IDataWidth
            where S : unmanaged, scalar
        {
            new S Scalar {get;}

            scalar<W> address<W>.Scalar => Scalar.Value;
        }

    }

    partial class AsmTypes
    {
        public readonly struct address : location<address>
        {
            [MethodImpl(Inline)]
            public static implicit operator address(variant src)
                => new address(src);

            [MethodImpl(Inline)]
            public address(variant src)
            {
                this.Scalar = src;
            }

            public variant Scalar {get;}
        }

        public readonly struct address8 : address<address8,scalar8,W8>
        {
            [MethodImpl(Inline)]
            public address8(scalar8 src)
            {
                this.Scalar = src;
            }

            public scalar8 Scalar {get;}
        }

        public readonly struct address16 : address<address16,scalar16,W16>
        {
            [MethodImpl(Inline)]
            public address16(scalar16 src)
            {
                this.Scalar = src;
            }

            public scalar16 Scalar {get;}
        }

        public readonly struct address32 : address<address32,scalar32,W32>
        {
            [MethodImpl(Inline)]
            public address32(scalar32 src)
            {
                this.Scalar = src;
            }

            public scalar32 Scalar {get;}
        }

        public readonly struct address64 : address<address64,scalar64,W64>
        {
            [MethodImpl(Inline)]
            public address64(scalar64 src)
            {
                this.Scalar = src;
            }

            public scalar64 Scalar {get;}
        }    
    }
}