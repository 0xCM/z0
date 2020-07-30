//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Collections.Immutable;

    using Z0.Dac;    

    class CcwBuilder : ICcwData
    {
        CcwData _ccwData;

        readonly SOSDac _sos;

        readonly RuntimeBuilder _builder;

        public CcwBuilder(SOSDac sos, RuntimeBuilder builder)
        {
            _sos = sos;
            _builder = builder;
        }

        public bool Init(ulong obj)
        {
            if (!_sos.GetObjectData(obj, out V45ObjectData data))
                return false;

            if (data.CCW == 0)
                return false;

            Address = data.CCW;
            return _sos.GetCCWData(data.CCW, out _ccwData);
        }

        public ulong Address { get; private set; }

        ulong ICcwData.Address 
            => _ccwData.CCWAddress;
 
        ulong ICcwData.IUnknown 
            => _ccwData.OuterIUnknown;
 
        ulong ICcwData.Object 
            => _ccwData.ManagedObject;
 
        ulong ICcwData.Handle 
            => _ccwData.Handle;
 
        int ICcwData.RefCount 
            => _ccwData.RefCount + _ccwData.JupiterRefCount;
 
        int ICcwData.JupiterRefCount 
            => _ccwData.JupiterRefCount;

        ImmutableArray<ComInterfaceData> ICcwData.GetInterfaces()
        {
            COMInterfacePointerData[]? ifs = _sos.GetCCWInterfaces(Address, _ccwData.InterfaceCount);
            if (ifs is null)
                return ImmutableArray<ComInterfaceData>.Empty;

            return _builder.CreateComInterfaces(ifs);
        }
    }
}