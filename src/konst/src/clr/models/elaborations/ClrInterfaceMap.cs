//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Text;

    using static Part;

    /// <summary>
    /// Captures the same information found in a <see cref="InterfaceMapping"/>
    /// </summary>
    public struct ClrInterfaceMap
    {
        public Index<ClrMethod> Specs;

        public ClrType ContractType;

        public Index<ClrMethod> Implementors;

        public ClrType HostType;

        public uint OperationCount
        {
            [MethodImpl(Inline)]
            get => Specs.Count;
        }

        public static void format(in ClrInterfaceMap src, StringBuilder dst)
        {
            dst.AppendLine(string.Format("{0} -> {1}", src.ContractType, src.HostType));
            var count = src.OperationCount;
            for(var i=0u; i<count; i++)
            {
                ref readonly var spec = ref src.Specs[i];
                ref readonly var impl = ref src.Implementors[i];
            }
        }

        // public static void FormatInterfaceMapping(Type host, Type contract)
        // {
        // InterfaceMapping map = host.GetInterfaceMap(contract);
        // Console.WriteLine($"{map.TargetType}: GetInterfaceMap({map.InterfaceType})");
        // for (int counter = 0; counter < map.InterfaceMethods.Length; counter++) {
        //     MethodInfo im = map.InterfaceMethods[counter];
        //     MethodInfo tm = map.TargetMethods[counter];
        //     Console.WriteLine($"   {im.DeclaringType}::{im.Name} --> {tm.DeclaringType}::{tm.Name} ({(im == tm ? "same" : "different")})");
        //     Console.WriteLine("       MethodHandle 0x{0:X} --> MethodHandle 0x{1:X}",
        //         im.MethodHandle.Value.ToInt64(), tm.MethodHandle.Value.ToInt64());
        //     Console.WriteLine("       FunctionPtr  0x{0:X} --> FunctionPtr  0x{1:X}",
        //         im.MethodHandle.GetFunctionPointer().ToInt64(), tm.MethodHandle.GetFunctionPointer().ToInt64());
        // }
        // Console.WriteLine();
        // }
    }
}