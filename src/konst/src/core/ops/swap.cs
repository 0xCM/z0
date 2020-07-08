//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    partial struct core
    {         
        /// <summary>
        /// The canonical swap function, sort of
        /// </summary>
        /// <param name="lhs">The left value</param>
        /// <param name="rhs">The right value</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void swap<T>(in T lhs, in T rhs)
        {
            var temp = lhs;
            edit(lhs) = rhs;
            edit(rhs) = temp;
        }

        /// <summary>
        /// Exchanges operand targets
        /// </summary>
        /// <param name="pLhs"></param>
        /// <param name="pRhs"></param>
        /// <typeparam name="T"></typeparam>
        /// <remarks>
        /// T:uint32: mov eax,[rdx] => mov [rcx],eax => mov eax,[rcx] => mov [rdx],eax
        /// T:uint32: *rdx -> eax => eax -> *rcx => *rcx -> eax -> eax -> *rdx
        /// T:uint64: mov rax,[rdx] => mov [rcx],rax => mov rax,[rcx] => mov [rdx],rax
        /// </remarks>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe void swap<T>(T* pLhs, T* pRhs)
            where T : unmanaged
        {
            var pTmp = pLhs;
            *pLhs = *pRhs;
            *pRhs = *pTmp;
        }
    }
}