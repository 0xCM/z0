using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Z0;

class zfunc
{
    public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

    public const MethodImplOptions NotInline = MethodImplOptions.NoInlining;
    
    [MethodImpl(Inline)]
    public static ulong nateval<N>(N n = default)
        where N : unmanaged, ITypeNat
            => NatMath2.natval(n);

    [MethodImpl(Inline)]
    public static int bitsize<T>(T t = default)
        where T : struct
            => Unsafe.SizeOf<T>()*8;


    [MethodImpl(Inline)]
    public static int size<T>(T t = default)
        where T : struct
            => Unsafe.SizeOf<T>();

    [MethodImpl(Inline)]
    public static T[] array<T>(params T[] src)
        => src;

    /// <summary>
    /// Adds an offset to a reference, measured relative to the reference type
    /// </summary>
    /// <param name="src">The source reference</param>
    /// <param name="bytes">The number of elements to advance</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T seek<T>(ref T src, int count)
        => ref Unsafe.Add(ref src, count);

    /// <summary>
    /// Returns a reference to the location of the first span element
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static ref T head<T>(Span<T> src)
        => ref MemoryMarshal.GetReference<T>(src);
}