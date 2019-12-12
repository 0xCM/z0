//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    using static As;
    using static AsIn;
    
    /// <summary>
    /// Defines a segmented bitfield indexed by enum values
    /// </summary>
    /// <remarks>
    /// Each of the literals defined by the enum must represent an unsigned integer 
    /// within the inclusive range [0,31]
    /// </remarks>
    public struct BitField<E>
        where E : unmanaged, Enum
    {
        const byte MaxFieldWidth = 7;
        
        Vector256<byte> spec;
            
        public byte this [E field]
        {
            [MethodImpl(Inline)]
            get => GetWidth(field);

            [MethodImpl(Inline)]
            set => SetWidth(field, value);
        }        

        [MethodImpl(Inline)]
        public void SetWidth(E field, byte width)
            => spec = spec.WithElement(eint(field), BitMask.lomask<byte>(math.clamp(width,MaxFieldWidth)));

        [MethodImpl(Inline)]
        public byte GetWidth(E field)
            => (byte)Bits.width(spec.GetElement(eint(field)));

        [MethodImpl(Inline)]
        public Vector128<T> Filter<T>(Vector128<T> src)
            where T : unmanaged
                => vgeneric<T>(dinx.vand(v8u(src), dinx.vlo(spec)));

        [MethodImpl(Inline)]
        public Vector256<T> Filter<T>(Vector256<T> src)
            where T : unmanaged
                => vgeneric<T>(dinx.vand(v8u(src), spec));
    }
}