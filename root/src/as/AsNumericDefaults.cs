//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static AsIn;

    public static class AsNumericDefaults
    {
        /// <summary>
        /// Creates an IAsNumeric[S,T] realization via a concrete implementation type
        /// </summary>
        /// <typeparam name="R">The concrete reification</typeparam>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The numeric target type</typeparam>
        [MethodImpl(Inline)]
        public static AsNumeric<R,S,T> Reify<R,S,T>()
            where T : unmanaged
            where R : unmanaged, IAsNumeric<S,T>
                => new AsNumeric<R,S,T>(default(R));

        public readonly struct AsNumeric<R,S,T> : IAsNumeric<S,T>
            where T : unmanaged
            where R : unmanaged, IAsNumeric<S,T>
        {
            [MethodImpl(Inline)]
            public static implicit operator R(AsNumeric<R,S,T> src)
                => src.Reification;

            readonly R Reification;

            [MethodImpl(Inline)]
            internal AsNumeric(R reification)
            {
                this.Reification = reification;
            }
            
            [MethodImpl(Inline)]
            public T As(S src)
                => Reification.As(src);
        }

        public readonly struct AsU8<S> : IAsNumeric<AsU8<S>,S,byte>
        {        
            
            [MethodImpl(Inline)]
            public byte As(S src)
                => Unsafe.As<S,byte>(ref src);            
        }

        public readonly struct AsU16<S> : IAsNumeric<AsU16<S>,S,ushort>
        {        
            [MethodImpl(Inline)]
            public ushort As(S src)
                => Unsafe.As<S,ushort>(ref src);
        }

        public readonly struct AsU32<S> : IAsNumeric<AsU32<S>,S,uint>
        {        
            [MethodImpl(Inline)]
            public uint As(S src)
                => Unsafe.As<S,uint>(ref src);
        }

        public readonly struct AsU64<S> : IAsNumeric<AsU64<S>,S,ulong>
        {        
            [MethodImpl(Inline)]
            public ulong As(S src)
                => Unsafe.As<S,ulong>(ref src);
        }

        public readonly struct AsI8<S> : IAsNumeric<AsI8<S>,S,sbyte>
        {        
            [MethodImpl(Inline)]
            public sbyte As(S src)
                => Unsafe.As<S,sbyte>(ref src);
        }

        public readonly struct AsI16<S> : IAsNumeric<AsI16<S>,S,short>
        {        
            [MethodImpl(Inline)]
            public short As(S src)
                => Unsafe.As<S,short>(ref src);
        }

        public readonly struct AsI32<S> : IAsNumeric<AsI32<S>,S,int>
        {        
            [MethodImpl(Inline)]
            public int As(S src)
                => Unsafe.As<S,int>(ref src);
        }

        public readonly struct AsI64<S> : IAsNumeric<AsI64<S>,S,long>
        {        
            [MethodImpl(Inline)]
            public long As(S src)
                => Unsafe.As<S,long>(ref src);
        }

        public readonly struct AsF32<S> : IAsNumeric<AsF32<S>,S,float>
        {        
            [MethodImpl(Inline)]
            public float As(S src)
                => Unsafe.As<S,float>(ref src);
        }

        public readonly struct AsF64<S> : IAsNumeric<AsF64<S>,S,double>
        {        
            [MethodImpl(Inline)]
            public double As(S src)
                => Unsafe.As<S,double>(ref src);
        }    
    }
}