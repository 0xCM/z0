//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static AppErrorMsg;
    using static CheckEnum;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public interface IChecker<V> : IValidator
        where V : struct, IValidator
    {
        static V Checker => default(V);
    }

    public interface ICheckEnum : IChecker<CheckEnum>
    {        
        [MethodImpl(Inline)]
        void eq<E>(E lhs, E rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where E : unmanaged, Enum
        {
            if(!u64(lhs).Equals(u64(rhs)))
                throw failed(ClaimKind.Eq, NotEqual(lhs,rhs, caller, file, line));
        }
    }

    public readonly struct CheckEnum : ICheckEnum
    {
        [MethodImpl(Inline)]
        internal static unsafe V numeric<E,V>(E e)
            where E : unmanaged, Enum
            where V : unmanaged
                => Unsafe.Read<V>((V*)(&e));

        /// <summary>
        /// Interprets an enum value as an unsigned 64-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        internal static ulong u64<E>(E e)
            where E : unmanaged, Enum
                => numeric<E,ulong>(e);
    }
 
}