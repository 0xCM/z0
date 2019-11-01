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
    
    /// <summary>
    /// Defines content for a parallel 16-way lookup
    /// </summary>
    /// <remarks>
    /// Each struct data member specifies 1 of 16 identifying keys; ultimately, this data structure
    /// provides a view over 16 bytes of data that is convenient for expressing bit-level lookup problems
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Size = Size)]
    public struct Lut16
    {
        public const int Size = 16;

        LookupKey key0;

        LookupKey key1;

        LookupKey key2;

        LookupKey key3;

        LookupKey key4;

        LookupKey key5;

        LookupKey key6;

        LookupKey key7;
         
        LookupKey key8;

        LookupKey key9;

        LookupKey keyA;

        LookupKey keyB;

        LookupKey keyC;

        LookupKey keyD;

        LookupKey keyE;

        LookupKey keyF;

        public LookupKey this[LookupSlot key]
        {
            [MethodImpl(Inline)]
            get => Lookup.GetKey(in this, key);

            [MethodImpl(Inline)]
            set => Lookup.SetKey(ref this, key, value);
        }

        public Vector128<byte> Vector
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