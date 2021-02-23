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
    /// Captures the content of a <see cref="InterfaceMapping"/>
    /// </summary>
    public struct ClrInterfaceMap : ITextual
    {
        public Index<MethodInfo> Specs;

        public Type SpecType;

        public Index<MethodInfo> Impl;

        public Type ImplType;

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

        // https://mattwarren.org/2020/02/19/Under-the-hood-of-Default-Interface-Methods/
        public void Format(ITextBuffer dst)
        {
            dst.AppendLine(string.Format("{0} -> {1}", SpecType.Name, ImplType.Name));
            var count = OperationCount;
            for(var i=0u; i<count; i++)
            {
                ClrMethod spec = Specs[i];
                ClrMethod impl = Impl[i];
                dst.AppendLine($"   {spec.DeclaringType}::{spec.Name} --> {impl.DeclaringType}::{impl.Name}");
                dst.AppendLineFormat("       MethodHandle 0x{0:X} --> MethodHandle 0x{1:X}", spec.HandleAddress, impl.HandleAddress);
                dst.AppendLineFormat("       FunctionPtr  0x{0:X} --> FunctionPtr  0x{1:X}", spec.PointerAddress, impl.PointerAddress);
            }
        }

        public override string ToString()
            => Format();
    }
}