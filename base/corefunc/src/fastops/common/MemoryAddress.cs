//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Diagnostics.CodeAnalysis;

    using static zfunc;

    public readonly struct MemoryAddress : IEquatable<MemoryAddress>, IComparable<MemoryAddress>
    {
        public static MemoryAddress Zero => default;

        public readonly ulong Origin;

        public readonly ushort Local;

        public bool NonZero
        {
            [MethodImpl(Inline)]
            get => Origin != 0;
        }
        
        [MethodImpl(Inline)]
        public static MemoryAddress Define(ulong origin, ulong local = 0)
            => new MemoryAddress(origin, local);

        [MethodImpl(Inline)]
        public static MemoryAddress Define(IntPtr origin, ulong local = 0)
            => new MemoryAddress((ulong)origin.ToInt64(), local);

        [MethodImpl(Inline)]
        public static implicit operator MemoryAddress(ulong src)
            => Define(src);

        [MethodImpl(Inline)]
        public static implicit operator ulong(MemoryAddress src)
            => src.Origin;

        [MethodImpl(Inline)]
        public static bool operator==(MemoryAddress a, MemoryAddress b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(MemoryAddress a, MemoryAddress b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator<(MemoryAddress a, MemoryAddress b)
            => a.Origin < b.Origin;

        [MethodImpl(Inline)]
        public static bool operator>(MemoryAddress a, MemoryAddress b)
            => a.Origin > b.Origin;

        [MethodImpl(Inline)]
        public static bool operator<=(MemoryAddress a, MemoryAddress b)
            => a.Origin <= b.Origin;

        [MethodImpl(Inline)]
        public static bool operator>=(MemoryAddress a, MemoryAddress b)
            => a.Origin >= b.Origin;
            
        [MethodImpl(Inline)]
        MemoryAddress(ulong absolute, ulong relative)
        {
            this.Origin = absolute;
            this.Local = relative == 0 ? (ushort)0 : (ushort)(absolute - relative);
        }
        
        public string Format(bool hex = true)
            => hex  ? (Local != 0 ? concat(this.Local.FormatSmallHex(true), spaced(pipe()), this.Origin.FormatAsmHex()) : Origin.FormatAsmHex())
                    : (Local != 0 ? concat(this.Local.ToString().PadLeft(5, AsciDigits.A0), spaced(pipe()), this.Origin.ToString()) : this.Origin.ToString());

        public override string ToString()
            => Format();         

        public override int GetHashCode()
            => Origin.GetHashCode();

        [MethodImpl(Inline)]
        public bool Equals(MemoryAddress src)
            => Origin == src.Origin;

        public override bool Equals(object obj)
            => obj is MemoryAddress a && Equals(a);                    

        [MethodImpl(Inline)]
        public int CompareTo([AllowNull] MemoryAddress other)
            => this == other ? 0 : this < other ? -1 : 1;

        [MethodImpl(Inline)]
        public unsafe T* ToPointer<T>()
            where T : unmanaged
                => (T*)Origin;         
    }
}