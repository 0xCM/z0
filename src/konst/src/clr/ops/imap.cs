//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    partial struct Clr
    {
        /// <summary>
        /// Queries the host type for a <see cref='ClrInterfaceMap'/>
        /// </summary>
        /// <param name="host">The reifying type</param>
        /// <param name="contract">The contract type</param>
        [MethodImpl(Inline), Op]
        public static ClrInterfaceMap imap(Type host, Type contract)
        {
            var src = host.InterfaceMap(contract);
            var dst = new ClrInterfaceMap();
            dst.Specs = src.InterfaceMethods;
            dst.SpecType = src.InterfaceType;
            dst.Impl = src.TargetMethods;
            dst.ImplType = src.TargetType;
            return dst;
        }

        public static ClrInterfaceMap imap<H,C>()
            where C : class
                => imap(typeof(H), typeof(C));
    }

    /*

    //
    // Summary:
    //     Retrieves the mapping of an interface into the actual methods on a class that
    //     implements that interface.
    public struct InterfaceMapping
    {
        //
        // Summary:
        //     Shows the methods that are defined on the interface.
        public MethodInfo[] InterfaceMethods;

        //
        // Summary:
        //     Shows the type that represents the interface.
        public Type InterfaceType;

        //
        // Summary:
        //     Shows the methods that implement the interface.
        public MethodInfo[] TargetMethods;

        //
        // Summary:
        //     Represents the type that was used to create the interface mapping.
        public Type TargetType;
    }
    */
}