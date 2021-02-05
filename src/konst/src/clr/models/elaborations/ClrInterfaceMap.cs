//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    /// <summary>
    /// Captures the same information found in a <see cref="InterfaceMapping"/>
    /// </summary>
    public struct ClrInterfaceMap : ITextual
    {
        public Index<ClrMethod> Specs;

        public ClrType InterfaceType;

        public Index<ClrMethod> Implementors;

        public ClrType HostType;

        public uint OperationCount
        {
            [MethodImpl(Inline)]
            get => Specs.Count;
        }

        public string Format()
        {
            var buffer = text.buffer();
            Format(buffer);
            return buffer.Emit();
        }

        public void Format(ITextBuffer dst)
        {
            dst.AppendLine(string.Format("{0} -> {1}", InterfaceType, HostType));
            var count = OperationCount;
            for(var i=0u; i<count; i++)
            {
                ref readonly var iface = ref Specs[i];
                ref readonly var impl = ref Implementors[i];
                dst.AppendLine($"   {iface.DeclaringType}::{iface.Name} --> {impl.DeclaringType}::{impl.Name}");
                dst.AppendLineFormat("       MethodHandle 0x{0:X} --> MethodHandle 0x{1:X}", iface.HandleAddress, impl.HandleAddress);
                dst.AppendLineFormat("       FunctionPtr  0x{0:X} --> FunctionPtr  0x{1:X}", iface.PointerAddress, impl.PointerAddress);
            }
        }

        public override string ToString()
            => Format();
        // public static void FormatInterfaceMapping(Type host, Type contract)
        // {
        // InterfaceMapping map = host.GetInterfaceMap(contract);
        // Console.WriteLine($"{map.TargetType}: GetInterfaceMap({map.InterfaceType})");
        // for (int counter = 0; counter < map.InterfaceMethods.Length; counter++) {
        //     MethodInfo iface = map.InterfaceMethods[counter];
        //     MethodInfo impl = map.TargetMethods[counter];
        //     Console.WriteLine($"   {iface.DeclaringType}::{iface.Name} --> {impl.DeclaringType}::{impl.Name} ({(iface == impl ? "same" : "different")})");
        //     Console.WriteLine("       MethodHandle 0x{0:X} --> MethodHandle 0x{1:X}", iface.MethodHandle.Value.ToInt64(), impl.MethodHandle.Value.ToInt64());
        //     Console.WriteLine("       FunctionPtr  0x{0:X} --> FunctionPtr  0x{1:X}", iface.MethodHandle.GetFunctionPointer().ToInt64(), impl.MethodHandle.GetFunctionPointer().ToInt64());
        // }
        // Console.WriteLine();
        // }
    }
}