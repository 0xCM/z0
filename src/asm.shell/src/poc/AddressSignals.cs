// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows;

    using static Z0.Root;
    using static Z0.core;

    public unsafe class AddressSignals : IDisposable
    {
        public static AddressSignals service()
            => TheOnly;
        const uint Capacity = 64;

        static AddressSignals TheOnly;

        static int AllocationCount;

        Index<MemoryAddress> ValueLocations;

        NativeBuffer<ulong> AllocatedValues;

        AddressSignals()
        {
            ValueLocations = new MemoryAddress[Capacity];
            AllocatedValues = Buffers.native<ulong>(Capacity*8);
            AllocatedValues.Clear();
            AllocationCount = -1;
        }

        static AddressSignals()
        {
            TheOnly = new();
        }

        public void Dispose()
        {
            AllocatedValues.Dispose();
        }

        [MethodImpl(Inline)]
        public unsafe ref readonly ulong Read(AddressToken token)
        {
            return ref AllocatedValues[token.Key];
        }

        public void Update(AddressToken token, ulong value)
        {
            ValueLocations[token.Key].Ref<ulong>() = value;
            KernelBase.WakeByAddressAll(token.Address.Pointer());
        }

        public void Wait(AddressToken token)
        {
            KernelBase.WaitOnAddress(token.Address.Pointer(), ValueLocations[token.Key].Pointer(), 8, uint.MaxValue);
        }

        [MethodImpl(Inline)]
        public bool Allocate(out AddressToken token)
        {
            var i = inc(ref AllocationCount);
            if(i < Capacity)
            {
                token = new AddressToken((uint)i, ValueLocations[i]);
                return true;
            }
            else
            {
                token = default;
                return false;
            }
        }

        public struct AddressToken
        {
            public MemoryAddress Address {get;}

            internal uint Key {get;}

            [MethodImpl(Inline)]
            public AddressToken(uint key, MemoryAddress address)
            {
                Key = key;
                Address = address;
            }
        }
    }
}