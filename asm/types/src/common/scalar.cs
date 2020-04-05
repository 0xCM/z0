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
        public interface scalar
        {
            variant Value {get;}
        }
        

        public interface scalar<W,T> : scalar
            where W : unmanaged, IDataWidth
            where T : unmanaged
        {
            new T Value {get;}     

            variant scalar.Value => CastNumeric.convert<T,ulong>(Value);   
        }    

        public interface scalar<F,W,T> : scalar<W,T>
            where F : unmanaged, scalar<F,W,T>
            where W : unmanaged, IDataWidth
            where T : unmanaged
        {
            
        }    
    }

    partial class AsmTypes
    {
        public readonly struct scalar<W> : scalar
            where W : unmanaged, IDataWidth
        {
            [MethodImpl(Inline)]
            public static implicit operator scalar<W>(variant src)
                => new scalar<W>(src);

            [MethodImpl(Inline)]
            public static implicit operator variant(scalar<W> src)
                => src.Value;

            [MethodImpl(Inline)]
            public scalar(variant value)
            {
                this.Value = value;
            }
            
            public variant Value {get;}
        }
    }
}