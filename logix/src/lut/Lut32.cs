//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;
    
    [StructLayout(LayoutKind.Sequential, Size = Size)]
    public struct Lut32
    {
        public const int Size = 32;

        Lut16 Lo;

        Lut16 Hi;

        public Vector256<byte> Vector
        {
            [MethodImpl(Inline)]
            get => Lookup.LoadVector(in this);

            [MethodImpl(Inline)]
            set => Lookup.From(value, ref this);
        }

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => Lookup.AsSpan(in this);
        }
    }
}