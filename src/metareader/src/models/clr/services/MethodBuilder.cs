//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;

    using Z0.Dac;    

    internal class MethodBuilder : IMethodData, IDisposable
    {
        MethodDescData _mdData;
        
        CodeHeaderData _codeHeaderData;
        
        IMethodHelpers? _helpers;

        public bool Init(SOSDac sos, ulong mt, int i, IMethodHelpers helpers)
        {
            ulong slot = sos.GetMethodTableSlot(mt, i);

            if (!sos.GetCodeHeaderData(slot, out _codeHeaderData))
                return false;

            _helpers = helpers;
            MethodDesc = _codeHeaderData.MethodDesc;
            return sos.GetMethodDescData(_codeHeaderData.MethodDesc, 0, out _mdData);
        }

        public bool Init(SOSDac sos, ulong methodDesc, IMethodHelpers helpers)
        {
            MethodDesc = methodDesc;
            if (!sos.GetMethodDescData(methodDesc, 0, out _mdData))
                return false;

            _helpers = helpers;
            ulong slot = sos.GetMethodTableSlot(_mdData.MethodTable, _mdData.SlotNumber);
            return sos.GetCodeHeaderData(slot, out _codeHeaderData);
        }

        public Dac.ObjectPool<MethodBuilder>? Owner { get; set; }
        
        public IMethodHelpers Helpers 
            => _helpers!;

        public int Token    
            => (int)_mdData.MDToken;

        public ulong MethodDesc { get; private set; }
        
        public MethodCompilationType CompilationType 
            => (MethodCompilationType)_codeHeaderData.JITType;

        public ulong HotStart 
            => _mdData.NativeCodeAddr;

        public uint HotSize 
            => _codeHeaderData.HotRegionSize;

        public ulong ColdStart 
            => _codeHeaderData.ColdRegionStart;

        public uint ColdSize 
            => _codeHeaderData.ColdRegionSize;

        public void Dispose()
        {
            _helpers = null;
            var owner = Owner;
            Owner = null;
            owner?.Return(this);
        }
    }
}