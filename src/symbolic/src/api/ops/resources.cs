//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
  
    partial class Symbolic
    {
        [MethodImpl(Inline), Op]
        public static AsciResources<asci2> resources(string name, asci2[] content, string description)
            => AsciCodes.resources(name,content,description);

        [MethodImpl(Inline), Op]
        public static AsciResources<asci4> resources(string name, asci4[] content, string description)
            => AsciCodes.resources(name,content,description);

        [MethodImpl(Inline), Op]
        public static AsciResources<asci8> resources(string name, asci8[] content, string description)
            => AsciCodes.resources(name,content,description);        

        [MethodImpl(Inline), Op]
        public static AsciResources<asci16> resources(string name, asci16[] content, string description)
            => AsciCodes.resources(name,content,description);

        [MethodImpl(Inline), Op]
        public static AsciResources<asci32> resources(string name, asci32[] content, string description)
            => AsciCodes.resources(name,content,description);

        [MethodImpl(Inline), Op]
        public static AsciResources<asci64> resources(string name, asci64[] content, string description)
            => AsciCodes.resources(name,content,description);

        [MethodImpl(Inline), Op]
        public static AsciResources<asci2> resources(string name, AsciResource<asci2>[] content, string description)
            => AsciCodes.resources(name,content,description);

        [MethodImpl(Inline), Op]
        public static AsciResources<asci4> resources(string name, AsciResource<asci4>[] content, string description)
            => AsciCodes.resources(name,content,description);

        [MethodImpl(Inline), Op]
        public static AsciResources<asci8> resources(string name, AsciResource<asci8>[] content, string description)
            => AsciCodes.resources(name,content,description);

        [MethodImpl(Inline), Op]
        public static AsciResources<asci16> resources(string name, AsciResource<asci16>[] content, string description)
            => AsciCodes.resources(name,content,description);

        [MethodImpl(Inline), Op]
        public static AsciResources<asci32> resources(string name, AsciResource<asci32>[] content, string description)
            => AsciCodes.resources(name,content,description);

        [MethodImpl(Inline), Op]
        public static AsciResources<asci64> resources(string name, AsciResource<asci64>[] content, string description)
            => AsciCodes.resources(name,content,description);
    }
}