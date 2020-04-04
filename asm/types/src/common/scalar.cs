//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Types
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

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

    public readonly struct variant
    {
        [MethodImpl(Inline)]
        public static implicit operator byte(variant src)
            => (byte)src.inner;

        [MethodImpl(Inline)]
        public static implicit operator ushort(variant src)
            => (ushort)src.inner;

        [MethodImpl(Inline)]
        public static implicit operator uint(variant src)
            => (uint)src.inner;

        [MethodImpl(Inline)]
        public static implicit operator ulong(variant src)
            => (ulong)src.inner;

        [MethodImpl(Inline)]
        public static implicit operator variant(ulong src)
            => new variant(src);

        [MethodImpl(Inline)]
        public variant(ulong src)
        {
            this.inner = src;
        }

        readonly ulong inner;
    }

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

    public readonly struct scalar8 : scalar<scalar8,W8,byte>
    {
        [MethodImpl(Inline)]
        public scalar8(byte src)
        {
            this.Value = src;
        }

        public byte Value {get;}
    }

    public readonly struct scalar16 : scalar<scalar16,W16,ushort>
    {
        [MethodImpl(Inline)]
        public scalar16(ushort src)
        {
            this.Value = src;
        }

        public ushort Value {get;}
    }

    public readonly struct scalar32: scalar<scalar32,W32,uint>
    {
        [MethodImpl(Inline)]
        public scalar32(uint src)
        {
            this.Value = src;
        }

        public uint Value {get;}
    }

    public readonly struct scalar64: scalar<scalar64,W64,ulong>
    {
        [MethodImpl(Inline)]
        public scalar64(ulong src)
        {
            this.Value = src;
        }

       public ulong Value {get;}
    }        
}