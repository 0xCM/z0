//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    partial struct Reflex
    {
        /// <summary>
        /// Selects all instance/static and public/non-public fields declared or inherited by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline), Op]
        public static Indexed<FieldInfo> fields(Type src)
            => src.GetFields(BF);

        [MethodImpl(Inline), Op]
        public static Indexed<object> attributes(Type src)
            => src.GetCustomAttributes(false); 

        [MethodImpl(Inline), Op]
        public static Indexed<string> EnumNames(Type src)                   
            => sys.EnumNames(src);
    }
}