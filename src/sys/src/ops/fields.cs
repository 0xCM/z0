//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static ReflectionFlags;        
    using static OpacityKind;
    
    partial struct sys
    {
        /// <summary>
        /// Selects all instance/static and public/non-public fields declared or inherited by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Options), Opaque(GetTypeFields)]
        public static FieldInfo[] fields(Type src)
            => src.GetFields(BF_All);            
    }
}