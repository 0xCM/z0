using System;
using System.Runtime.CompilerServices;

class zfunc
{
    public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

    public const MethodImplOptions NotInline = MethodImplOptions.NoInlining;
    
    [MethodImpl(NotInline)]
    public static bool require(bool condition, [CallerMemberName] string caller = null, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
        => condition ? condition : throw new Exception($"Condition unsatisfied: line {line}, member {caller} in file {file}");

    public static bool badsize(int expect, int actual)
        => throw new Exception($"The size {actual} is not aligned with {expect}");

    public static T badsize<T>(int expect, int actual)
        => throw new Exception($"The size {actual} is not aligned with {expect}");

    [MethodImpl(NotInline)]
    public static Exception CountMismatch(int lhs, int rhs, [CallerMemberName] string caller = null,  
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
                => new Exception($"Count mismatch, {lhs} != {rhs}: line {line}, member {caller} in file {file}");

    [MethodImpl(NotInline)]
    public static Exception OutOfRange<T>(T value, T min, T max, [CallerMemberName] string caller = null, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => new Exception($"Value {value} is not between {min} and {max}: line {line}, member {caller} in file {file}");
    
    [MethodImpl(NotInline)]
    public static void ThrowOutOfRange<T>(T value, T min, T max, [CallerMemberName] string caller = null, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
        => throw OutOfRange(value,min,max,caller,file,line);
}