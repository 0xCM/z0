//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    partial struct z
    {         
        /// <summary>
        /// The canonical swap function, sort of
        /// </summary>
        /// <param name="lhs">The left value</param>
        /// <param name="rhs">The right value</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe void swap<T>(T* pLhs, T* pRhs)
            where T : unmanaged
        {
            var pTmp = pLhs;
            *pLhs = *pRhs;
            *pRhs = *pTmp;
        }

        /// <summary>
        /// Interchanges span elements i and j
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="i">An index of a span element</param>
        /// <param name="j">An index of a span element</param>
        /// <typeparam name="T">The span element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void swap<T>(Span<T> src, uint i, uint j)
            where T : unmanaged
        {
            if(i==j)
                return;

            ref var data = ref first(src);
            var a = seek(data, i);
            seek(data, i) = skip(data, j);
            seek(data, j) = a;
        }        
    }
}